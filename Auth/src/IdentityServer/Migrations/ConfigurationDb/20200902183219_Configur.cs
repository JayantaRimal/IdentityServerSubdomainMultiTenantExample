using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Migrations.ConfigurationDb
{
    public partial class Configur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ClientCorsOrigins",
                columns: new[] { "Id", "ClientId", "Origin" },
                values: new object[,]
                {
                    { 3, 4, "https://tenant1.localhost:4200" },
                    { 4, 4, "https://tenant2.localhost:4200" },
                    { 5, 4, "http://localhost:4200" },
                    { 6, 4, "https://localhost:4200" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 15, 54, 14, 941, DateTimeKind.Utc).AddTicks(102));

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

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 15, 54, 14, 945, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 15, 54, 14, 966, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 2, 15, 54, 14, 966, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 15, 54, 14, 944, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 15, 54, 14, 944, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 2, 15, 54, 14, 944, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 9, 2, 15, 54, 14, 944, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 15, 54, 14, 943, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 15, 54, 14, 943, DateTimeKind.Utc).AddTicks(7930));
        }
    }
}
