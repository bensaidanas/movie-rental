using Microsoft.EntityFrameworkCore.Migrations;

namespace Vena.Migrations
{
    public partial class addMembershipTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MembershipType_MembershipTypeId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembershipType",
                table: "MembershipType");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19ae6c80-1289-496c-b34e-7993c0ce0082");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffe9e7ff-ac22-474f-84bb-cd70c83a57d2");

            migrationBuilder.RenameTable(
                name: "MembershipType",
                newName: "MembershipTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembershipTypes",
                table: "MembershipTypes",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3046dbd5-f964-44fa-b2d9-5b35d5a78fd9", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "66b57a9f-4759-4e45-8884-41ebe86e0f70", 0, "6583c7fc-73ce-48fe-9ae4-bba798549c5c", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "5b338ce7-8e84-474f-9be9-ff4f2ef88965", false, "Vena.Venus" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MembershipTypes_MembershipTypeId",
                table: "Customers",
                column: "MembershipTypeId",
                principalTable: "MembershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MembershipTypes_MembershipTypeId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembershipTypes",
                table: "MembershipTypes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3046dbd5-f964-44fa-b2d9-5b35d5a78fd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66b57a9f-4759-4e45-8884-41ebe86e0f70");

            migrationBuilder.RenameTable(
                name: "MembershipTypes",
                newName: "MembershipType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembershipType",
                table: "MembershipType",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19ae6c80-1289-496c-b34e-7993c0ce0082", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ffe9e7ff-ac22-474f-84bb-cd70c83a57d2", 0, "7d2c75fc-a544-4c56-b617-87cbc68b3881", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "a3adbc96-97eb-46a7-ba98-0940a67621f2", false, "Vena.Venus" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MembershipType_MembershipTypeId",
                table: "Customers",
                column: "MembershipTypeId",
                principalTable: "MembershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
