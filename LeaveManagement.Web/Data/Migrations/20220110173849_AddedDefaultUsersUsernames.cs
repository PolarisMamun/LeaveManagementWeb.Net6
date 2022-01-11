using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3",
                column: "ConcurrencyStamp",
                value: "2f2325e6-e959-4a33-902c-9aba33e16602");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3",
                column: "ConcurrencyStamp",
                value: "cd82c264-8383-479e-bc34-666dd1690e82");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c500d542-164e-4c67-b309-51a739b05f16",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6313640b-6853-4cbe-88b7-57ed36655028", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDEKmeAWsIgmOsByiRtlpX6QRCHfC+u9IkItOKwrV4KBAjLmtZK6pdC9k7BJ77nbgA==", "1a2476c9-928a-411b-a19a-0f03ce40ed55", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2389b3d-6bea-4b12-9738-c63f0415978b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "17887e70-0f73-4548-8622-e79ac172d8ce", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBbouUQ8k/VgDfZoa5EttLJQG/zqwsr2/Hx+KDWZ5fZ3XllE9XEvGH0/jBh1UYifTg==", "e7458abf-3c54-4142-9895-b94dba89d01b", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3",
                column: "ConcurrencyStamp",
                value: "089dbd69-8b57-4c78-a954-816a4ac718af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3",
                column: "ConcurrencyStamp",
                value: "d915b449-0f9d-4189-90bd-acbc79149348");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c500d542-164e-4c67-b309-51a739b05f16",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a56e8639-664a-40d8-a666-09c5e8c9f9c3", false, null, "AQAAAAEAACcQAAAAELBvEi2VehJx8xJDmUHQI9dC1xPf+C66F4huEh9ko0g1PFUIBHsVwji1iYX/Z4vusA==", "5d65401c-48ca-4499-80f2-b0a5cccf72c6", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2389b3d-6bea-4b12-9738-c63f0415978b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "198c4414-5de0-4373-b5df-28ec34aa0f99", false, null, "AQAAAAEAACcQAAAAEDdl8e2+HKq4m8KTtoLk9Z07rOAboHRBDaKP90Rh+O2K2BwlXHinROrbJ17gW+HP7Q==", "81674797-91f3-4d0f-8da6-5150fd72bc2d", null });
        }
    }
}
