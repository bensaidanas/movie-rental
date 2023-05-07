using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vena.Migrations
{
    public partial class AddMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "610671bb-e5a0-4db3-b714-cf575b2f3e87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0613df1b-64cf-4ef4-8674-9697f0f215b5");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    RentalRate = table.Column<double>(type: "float", nullable: false),
                    NumberInStock = table.Column<byte>(type: "tinyint", nullable: false),
                    NumberAvailable = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37c0a942-a059-4d42-a4d4-21418b7a70f5", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "18cc63cc-152b-43dc-8d5c-e0de733e6345", 0, "853bb593-a259-440a-8255-b8a4058ba654", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "40b17a7b-b6a8-40e9-b81a-9959d01d4cad", false, "Vena.Venus" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37c0a942-a059-4d42-a4d4-21418b7a70f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18cc63cc-152b-43dc-8d5c-e0de733e6345");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "610671bb-e5a0-4db3-b714-cf575b2f3e87", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0613df1b-64cf-4ef4-8674-9697f0f215b5", 0, "8aeb8403-7f8b-488f-ba1f-6ddaf7f04c61", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "fdc86a66-1c88-4588-9add-539e497a3226", false, "Vena.Venus" });
        }
    }
}
