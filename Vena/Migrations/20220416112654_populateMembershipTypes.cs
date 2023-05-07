using Microsoft.EntityFrameworkCore.Migrations;

namespace Vena.Migrations
{
    public partial class populateMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonth, DiscountRate) VALUES ('PayAsYouGo', 0, 0, 0)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonth, DiscountRate) VALUES ('Monthly', 30, 1, 10)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonth, DiscountRate) VALUES ('Quarterly', 90, 3, 15)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonth, DiscountRate) VALUES ('Annual', 300, 12, 20)");
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3046dbd5-f964-44fa-b2d9-5b35d5a78fd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66b57a9f-4759-4e45-8884-41ebe86e0f70");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ab6d0a4-5291-4dbe-9583-968aaa9c3962", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5de20477-8ad6-4030-b097-0918e04a9c56", 0, "36b6ea17-d88e-4cd8-ac9a-0f258303d538", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "db4ae862-a744-4d4d-81df-d4f70bb85793", false, "Vena.Venus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ab6d0a4-5291-4dbe-9583-968aaa9c3962");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5de20477-8ad6-4030-b097-0918e04a9c56");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3046dbd5-f964-44fa-b2d9-5b35d5a78fd9", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "66b57a9f-4759-4e45-8884-41ebe86e0f70", 0, "6583c7fc-73ce-48fe-9ae4-bba798549c5c", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "5b338ce7-8e84-474f-9be9-ff4f2ef88965", false, "Vena.Venus" });
        }
    }
}
