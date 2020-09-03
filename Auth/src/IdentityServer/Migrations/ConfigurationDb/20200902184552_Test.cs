using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Migrations.ConfigurationDb
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 160, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Origin",
                value: "http://tenant1.jayanta.com:4200");

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 2,
                column: "Origin",
                value: "http://tenant2.jayanta.com:4200");

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 3,
                column: "Origin",
                value: "https://tenant1.jayanta.com:4200");

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 4,
                column: "Origin",
                value: "https://tenant2.jayanta.com:4200");

            migrationBuilder.InsertData(
                table: "ClientCorsOrigins",
                columns: new[] { "Id", "ClientId", "Origin" },
                values: new object[,]
                {
                    { 7, 4, "http://jayanta.com:4200" },
                    { 8, 4, "https://jayanta.com:4200" }
                });

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostLogoutRedirectUri",
                value: "http://tenant1.jayanta.com:4200");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostLogoutRedirectUri",
                value: "http://tenant2.jayanta.com:4200");

            migrationBuilder.InsertData(
                table: "ClientPostLogoutRedirectUris",
                columns: new[] { "Id", "ClientId", "PostLogoutRedirectUri" },
                values: new object[] { 4, 4, "http://jayanta.com:4200" });

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "RedirectUri",
                value: "http://tenant1.jayanta.com:4200/callback.html");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 3,
                column: "RedirectUri",
                value: "http://tenant2.jayanta.com:4200/callback.html");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 4,
                column: "RedirectUri",
                value: "http://tenant1.jayanta.com:4200");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 5,
                column: "RedirectUri",
                value: "http://tenant2.jayanta.com:4200");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 6,
                column: "RedirectUri",
                value: "http://tenant1.jayanta.com:4200/silent-renew.html");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 7,
                column: "RedirectUri",
                value: "http://tenant2.jayanta.com:4200/silent-renew.html");

            migrationBuilder.InsertData(
                table: "ClientRedirectUris",
                columns: new[] { "Id", "ClientId", "RedirectUri" },
                values: new object[,]
                {
                    { 9, 4, "http://jayanta.com:4200/silent-renew.html" },
                    { 10, 4, "http://jayanta.com:4200/callback.html" },
                    { 8, 4, "http://jayanta.com:4200" }
                });

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 164, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 167, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 167, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 163, DateTimeKind.Utc).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 163, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 163, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 163, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 162, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 163, DateTimeKind.Utc).AddTicks(130));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 32, 19, 66, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Origin",
                value: "http://tenant1.localhost:4200");

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 2,
                column: "Origin",
                value: "http://tenant2.localhost:4200");

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 3,
                column: "Origin",
                value: "https://tenant1.localhost:4200");

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 4,
                column: "Origin",
                value: "https://tenant2.localhost:4200");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostLogoutRedirectUri",
                value: "http://tenant1.localhost:4200");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostLogoutRedirectUri",
                value: "http://tenant2.localhost:4200");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "RedirectUri",
                value: "http://tenant1.localhost:4200/callback.html");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 3,
                column: "RedirectUri",
                value: "http://tenant2.localhost:4200/callback.html");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 4,
                column: "RedirectUri",
                value: "http://tenant1.localhost:4200");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 5,
                column: "RedirectUri",
                value: "http://tenant2.localhost:4200");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 6,
                column: "RedirectUri",
                value: "http://tenant1.localhost:4200/silent-renew.html");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 7,
                column: "RedirectUri",
                value: "http://tenant2.localhost:4200/silent-renew.html");

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 32, 19, 70, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 32, 19, 73, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 32, 19, 73, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 32, 19, 69, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 32, 19, 69, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 32, 19, 69, DateTimeKind.Utc).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 32, 19, 69, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 32, 19, 69, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 32, 19, 69, DateTimeKind.Utc).AddTicks(1796));
        }
    }
}
