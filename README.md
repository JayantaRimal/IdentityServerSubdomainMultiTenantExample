##### Identity Server 4 Tenant Selection Application Example ####

You can follow the tutorial here :

https://jayantarimal.com.np/implement-domain-or-subdomain-based-multi-tenancy-in-identity-server/

To run this application follow the points belows :


## In Authorization Project ##

Add your database connection settings in your appsettings.development.json file.

Make the required changes to the database seed in IdentityDbcontext, MasterDbContext and ConfigurationDbContext. You need to give your client configuration as per your requirement.

Run the migrations for IdentityDbContext, PersistedGrantDbContext, MasterDbContext and ConfigurationDbContext and update database.

## In Authorization Project ##

Make the required changes to appsettings.development.json file

## In Angular Client ##
Make changes to the client config in app.module.ts as per your requirement.

## Some Aditional Steps ##

You may need to perform some additional steps to get the project working in IIS Express because we are using SSL for local development.

1. Edit the hosts file in C:\Windows\System32\drivers\etc\hosts and add the bindings
  ```
      127.0.0.1 jayanta.com 

      127.0.0.1 tenant1.jayanta.com

      127.0.0.1 tenant2.jayanta.com
  ```
2. If you are running in IIS Express then you must set the binding for IIS Express. To do that you need to go to your project directory. There you will see a .vs folder. Inside it you will find applicationhost.config file, which you must edit to add your subdomain binding with the appropriate port. This should be done for both the Authorization and the API project.

   - For Authorization project: 
    ```xml
        <binding protocol="https" bindingInformation="*:44318:" />
    ```
3. You may also need to set required permission. So, open Command Prompt with Administrator rights and execute the following command :
    ```xml
        netsh http add urlacl url=https://*:44318/ user=everyone
    ```
   - Similarly for the API project:
      ```xml
          <binding protocol="https" bindingInformation="*:44383:" />
      ```
   - Now the permissions again:
      ```console
          netsh http add urlacl url=https://*:44383/ user=everyone
      ```
4. You also need to use self signed wildcard certificate for IIS Express. To do this open up Powershell with Administrator rights and execute the following command:
  ```console
      $cert = New-SelfSignedCertificate -Subject "*.jayanta.com" -DnsName "jayanta.com", "*.jayanta.com" -CertStoreLocation "cert:\LocalMachine\My" -NotAfter (Get-Date).AddYears(5) $thumb = $cert.GetCertHashString() netsh http delete sslcert ipport=0.0.0.0:44318 netsh http delete sslcert ipport=0.0.0.0:44373 netsh http add sslcert ipport=0.0.0.0:44318 certhash=$thumb appid=`{214124cd-d05b-4309-9af9-9caa44b2b74a`} netsh http add sslcert ipport=0.0.0.0:44373 certhash=$thumb appid=`{214124cd-d05b-4309-9af9-9caa44b2b74a`} $StoreScope = 'LocalMachine' $StoreName = 'root' $Store = New-Object -TypeName System.Security.Cryptography.X509Certificates.X509Store -ArgumentList $StoreName, $StoreScope $Store.Open([System.Security.Cryptography.X509Certificates.OpenFlags]::ReadWrite) $Store.Add($cert) $Store.Close()
  ```    
5. You also need to run the Angular project with subdomain binding:
  ```console
      ng serve --host 0.0.0.0 --port 4200 --open --disable-host-check
  ```


Finally run the application.
