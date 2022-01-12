using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "leaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "leaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3",
                column: "ConcurrencyStamp",
                value: "f658dd80-cd60-497b-9046-5364268a159a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3",
                column: "ConcurrencyStamp",
                value: "40f805ae-3e40-44e2-8969-0dc16c79106e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c500d542-164e-4c67-b309-51a739b05f16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c89a7d0c-335f-4591-9da8-5bf26aa700fb", "AQAAAAEAACcQAAAAEM2Ai17Bx7iSgGq6mm+IxjWJlXKNFcWQTRFJrCx/Qmeu7Zo9zlWiicAu05+/BIy4NQ==", "f1d38d01-f9db-4c3b-8ba8-0f57ae00f314" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2389b3d-6bea-4b12-9738-c63f0415978b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9596230-90eb-4ab8-8bb9-26a51548fc2f", "AQAAAAEAACcQAAAAECyCM+DQF4UzMcX/Z1TZalEECz/yWklaTKkPtix4idqIdtSNwk+DGgca9IN+hS5TJg==", "af2f40f9-9cc1-45a2-9290-79935ad3e400" });
        }
    }
}
