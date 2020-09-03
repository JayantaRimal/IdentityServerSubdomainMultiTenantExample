using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed9758d7-eb93-4569-90c7-0595c96cc35b", "jayanta@jayantarimal.com.np", "AQAAAAEAACcQAAAAEI66s1DcHSNTj/3u2zfYy2zp0jvg0M05NeRCWAySHcd2IbKw/zJQkwUCNY/WtU7HYw==", "4a070ad4-5419-4c6d-9b6b-47de3adc87cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e05f777c-7e08-433f-ab77-a7e8db1d628c", "AQAAAAEAACcQAAAAEN/NFYyp6XLvbwFF/JPawFqlPYyh2bfpCBCP1IygKVWfDbtP+IgDHRcCKZmXA0LUbQ==", "661c1c62-9de5-4fad-98b0-f47f0b53eb9e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "524d22db-28d1-41a2-97e5-3138fe42d959", "jayanta@jayanta.com", "AQAAAAEAACcQAAAAEBoESjXtO2WQeyr16ywWoEp7rCXr9S4fNcbO414+qHulcif2KTPVbBXMbal+HY7PvA==", "383cb8b6-1927-4e48-b37e-1fcebfd880d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feee1f8a-9979-46f6-8f6f-06c4fc76bd1d", "AQAAAAEAACcQAAAAEAmgd+PiIxGLJP1Sk7MZAOmvsnFx5lBVxPxwh7hRYFyM0hh20LpWJYidZK3vRnhljQ==", "a4cf1773-2091-4252-b373-02bdead4bcbb" });
        }
    }
}
