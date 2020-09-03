import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { APP_INITIALIZER, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AuthModule, OidcConfigService } from 'angular-auth-oidc-client';
import { AppComponent } from './app.component';
import { CustomInterceptor } from './custom-interceptor';
import { AuthorizationGuard } from './authorization-guard.service';
import { FormsModule, ReactiveFormsModule, FormGroup } from '@angular/forms';
import { HttpClient } from '@angular/common/http';


export function configureAuth(oidcConfigService: OidcConfigService) {
    let sts: string  = 'https://'+window.location.hostname+':44318';

    return () =>
        oidcConfigService.withConfig({
            stsServer: sts, //dynamic auhtorization server name
            redirectUrl: window.location.origin, //dynamic redirect url
            postLogoutRedirectUri:window.location.origin,
            clientId: 'js',
            scope: 'openid profile web_api',
            responseType: 'code',
            silentRenew: true,
            silentRenewUrl: `${window.location.origin}/silent-renew.html`, //dynamic silent renew url
            customParams:{acr_values:'tenant:'+window.location.host.split('.')[0]+''} //acr_values
        });
}


@NgModule({
    declarations: [AppComponent],
    imports: [

        BrowserModule,
        ReactiveFormsModule,
        FormsModule,
        HttpClientModule,
        RouterModule.forRoot([
            { path: '', component: AppComponent },
            { path: 'home', component: AppComponent },
            { path: 'forbidden', component: AppComponent },
            { path: 'unauthorized', component: AppComponent },
        ]),
        AuthModule.forRoot(),

       
    ],
    providers: [
      OidcConfigService,
      {
          provide: APP_INITIALIZER,
          useFactory: configureAuth,
          deps: [OidcConfigService],
          multi: true,
      },
      {
        provide: HTTP_INTERCEPTORS,
        useClass: CustomInterceptor,
        multi: true
      },
      AuthorizationGuard
  ],
    bootstrap: [AppComponent],
})
export class AppModule {
  
}
