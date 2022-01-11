using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3", "089dbd69-8b57-4c78-a954-816a4ac718af", "Administrator", "ADMINISTRATOR" },
                    { "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3", "d915b449-0f9d-4189-90bd-acbc79149348", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c500d542-164e-4c67-b309-51a739b05f16", 0, "a56e8639-664a-40d8-a666-09c5e8c9f9c3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAELBvEi2VehJx8xJDmUHQI9dC1xPf+C66F4huEh9ko0g1PFUIBHsVwji1iYX/Z4vusA==", null, false, "5d65401c-48ca-4499-80f2-b0a5cccf72c6", null, false, null },
                    { "e2389b3d-6bea-4b12-9738-c63f0415978b", 0, "198c4414-5de0-4373-b5df-28ec34aa0f99", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEDdl8e2+HKq4m8KTtoLk9Z07rOAboHRBDaKP90Rh+O2K2BwlXHinROrbJ17gW+HP7Q==", null, false, "81674797-91f3-4d0f-8da6-5150fd72bc2d", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3", "c500d542-164e-4c67-b309-51a739b05f16" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3", "e2389b3d-6bea-4b12-9738-c63f0415978b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3", "c500d542-164e-4c67-b309-51a739b05f16" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3", "e2389b3d-6bea-4b12-9738-c63f0415978b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c500d542-164e-4c67-b309-51a739b05f16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2389b3d-6bea-4b12-9738-c63f0415978b");
        }
    }
}
