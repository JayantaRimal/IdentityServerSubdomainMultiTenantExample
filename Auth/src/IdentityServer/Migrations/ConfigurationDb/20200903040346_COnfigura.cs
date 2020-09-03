using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Migrations.ConfigurationDb
{
    public partial class COnfigura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 3, 4, 3, 45, 936, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.InsertData(
                table: "ClientPostLogoutRedirectUris",
                columns: new[] { "Id", "ClientId", "PostLogoutRedirectUri" },
                values: new object[,]
                {
                    { 5, 4, "https://tenant1.jayanta.com:4200" },
                    { 6, 4, "https://tenant2.jayanta.com:4200" },
                    { 7, 4, "https://jayanta.com:4200" }
                });

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 3, 4, 3, 45, 939, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 3, 4, 3, 45, 943, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 3, 4, 3, 45, 943, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 3, 4, 3, 45, 938, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 3, 4, 3, 45, 939, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 3, 4, 3, 45, 939, DateTimeKind.Utc).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 9, 3, 4, 3, 45, 939, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 3, 4, 3, 45, 938, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 3, 4, 3, 45, 938, DateTimeKind.Utc).AddTicks(4549));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 2, 18, 52, 3, 746, DateTimeKind.Utc).AddTicks(8316));

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
    }
}
