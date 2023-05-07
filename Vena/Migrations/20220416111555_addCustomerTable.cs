using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vena.Migrations
{
    public partial class addCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50a4e6cf-66e7-4483-add6-2a8abebf7ce8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4971b9a-7a3f-4a87-84a7-de6832c72156");

            migrationBuilder.CreateTable(
                name: "MembershipType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SignUpFee = table.Column<short>(type: "smallint", nullable: false),
                    DurationInMonth = table.Column<byte>(type: "tinyint", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipTypeId = table.Column<int>(type: "int", nullable: false),
                    MembershipEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_MembershipType_MembershipTypeId",
                        column: x => x.MembershipTypeId,
                        principalTable: "MembershipType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19ae6c80-1289-496c-b34e-7993c0ce0082", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ffe9e7ff-ac22-474f-84bb-cd70c83a57d2", 0, "7d2c75fc-a544-4c56-b617-87cbc68b3881", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "a3adbc96-97eb-46a7-ba98-0940a67621f2", false, "Vena.Venus" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MembershipTypeId",
                table: "Customers",
                column: "MembershipTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MembershipType");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19ae6c80-1289-496c-b34e-7993c0ce0082");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffe9e7ff-ac22-474f-84bb-cd70c83a57d2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50a4e6cf-66e7-4483-add6-2a8abebf7ce8", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c4971b9a-7a3f-4a87-84a7-de6832c72156", 0, "195ffbe7-7190-482f-81a9-d4316694d20a", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "b2fa1c23-932f-43d8-a54c-27faeec385b4", false, "Vena.Venus" });
        }
    }
}
