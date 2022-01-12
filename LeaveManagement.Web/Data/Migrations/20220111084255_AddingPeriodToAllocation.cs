using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "leaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "leaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6313640b-6853-4cbe-88b7-57ed36655028", "AQAAAAEAACcQAAAAEDEKmeAWsIgmOsByiRtlpX6QRCHfC+u9IkItOKwrV4KBAjLmtZK6pdC9k7BJ77nbgA==", "1a2476c9-928a-411b-a19a-0f03ce40ed55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2389b3d-6bea-4b12-9738-c63f0415978b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17887e70-0f73-4548-8622-e79ac172d8ce", "AQAAAAEAACcQAAAAEBbouUQ8k/VgDfZoa5EttLJQG/zqwsr2/Hx+KDWZ5fZ3XllE9XEvGH0/jBh1UYifTg==", "e7458abf-3c54-4142-9895-b94dba89d01b" });
        }
    }
}
