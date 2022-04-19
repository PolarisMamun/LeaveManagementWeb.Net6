using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3",
                column: "ConcurrencyStamp",
                value: "b74ce6bd-7597-4dfb-8a11-80fe2f1c33b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3",
                column: "ConcurrencyStamp",
                value: "449590f6-0b88-4711-a7c7-e50710ee484d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c500d542-164e-4c67-b309-51a739b05f16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44477d12-1eb4-4638-86a0-b3cba19c0a6c", "AQAAAAEAACcQAAAAEDVckaLSBtvBG3JlKfELGNe6LpN1TpFf3zWKQmkIoiOyFBoZreWiDU1KfJH/736ahw==", "720ae7df-9947-4057-a39c-b441178544ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2389b3d-6bea-4b12-9738-c63f0415978b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08a0437f-4e07-4714-87cd-841ed9721cab", "AQAAAAEAACcQAAAAEAa8pjOQxp510Su5lL/4V14Mm1F0UkgcrHs6RdhsaQUTSt57iVIgLQRCxv0HzVjk5w==", "ecd831a9-f056-4078-878a-aa774c724347" });
        }
    }
}
