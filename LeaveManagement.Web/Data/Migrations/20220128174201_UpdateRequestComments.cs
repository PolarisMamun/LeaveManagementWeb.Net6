using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3",
                column: "ConcurrencyStamp",
                value: "ff1526bc-bd81-478b-a23d-e76390a55c62");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3",
                column: "ConcurrencyStamp",
                value: "309886ba-e4ef-4a4a-a5a6-c0904cecb6be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c500d542-164e-4c67-b309-51a739b05f16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fc103b7-c297-4d85-b2e5-76bf0edc2a22", "AQAAAAEAACcQAAAAELk/tsVv0PtUDFPQxCE//L18CQZQByzEgMpXhjZ7Se2s+bo0PYWH6iaoRwNfs/4RvA==", "322d9d23-185d-425f-a1a7-b230a8a51e2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2389b3d-6bea-4b12-9738-c63f0415978b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e67768db-63f4-465b-b899-46e01c4dbee4", "AQAAAAEAACcQAAAAEGaIpfs7fa1TnS/JX7DjOZSn63rUyQdWkcA4Ahm1lIPxdmR9WCQ7sAFT3IkJF8E/JQ==", "34fb6436-c04c-4b91-85a4-1f72cea4eb81" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3",
                column: "ConcurrencyStamp",
                value: "b1b2395d-87ba-47c4-8d86-13ae46327f57");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3",
                column: "ConcurrencyStamp",
                value: "19b15129-aedb-40cf-b06d-468cbb721069");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c500d542-164e-4c67-b309-51a739b05f16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c92de3b-862d-4d2f-aff4-692064b16186", "AQAAAAEAACcQAAAAEDt3UQ4jQ0Wwiy7td23Wz2e4Rnex8OPpA8h9yR702F6Bz3kRLkYxLF04S1FSsl1drg==", "b882646a-5fc4-434e-9d58-8057795ffa50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2389b3d-6bea-4b12-9738-c63f0415978b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5d77771-f071-404b-9989-e5456da1e9e5", "AQAAAAEAACcQAAAAEPsEjsPkI2X1j2GeqtwY9B8tXWhaluhHPM1fPAlxur0LaSrozBQMloIpI7IyQWCULw==", "203138f9-481b-4bc7-9b22-78aaa2939263" });
        }
    }
}
