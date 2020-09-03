using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Migrations.ConfigurationDb
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 746, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.InsertData(
                table: "ClientRedirectUris",
                columns: new[] { "Id", "ClientId", "RedirectUri" },
                values: new object[,]
                {
                    { 19, 4, "https://jayanta.com:4200/callback.html" },
                    { 18, 4, "https://jayanta.com:4200/silent-renew.html" },
                    { 17, 4, "https://jayanta.com:4200" },
                    { 16, 4, "https://tenant2.jayanta.com:4200/silent-renew.html" },
                    { 11, 4, "https://tenant1.jayanta.com:4200/callback.html" },
                    { 14, 4, "https://tenant2.jayanta.com:4200" },
                    { 13, 4, "https://tenant1.jayanta.com:4200" },
                    { 12, 4, "https://tenant2.jayanta.com:4200/callback.html" },
                    { 15, 4, "https://tenant1.jayanta.com:4200/silent-renew.html" }
                });

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 750, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 753, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 753, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 749, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 749, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 749, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 749, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 749, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 749, DateTimeKind.Utc).AddTicks(1942));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 45, 51, 160, DateTimeKind.Utc).AddTicks(7865));

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
    }
}
