using Microsoft.EntityFrameworkCore.Migrations;

namespace Vena.Migrations
{
    public partial class populateGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES ('Horror')");
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES ('Animation')");
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES ('Adventure')");
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES ('Mystery')");
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1d1ca0c-a84a-4873-abbc-8ba25140e8c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "036b281c-a615-4dd2-8af9-918ea2b871fa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "610671bb-e5a0-4db3-b714-cf575b2f3e87", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0613df1b-64cf-4ef4-8674-9697f0f215b5", 0, "8aeb8403-7f8b-488f-ba1f-6ddaf7f04c61", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "fdc86a66-1c88-4588-9add-539e497a3226", false, "Vena.Venus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "610671bb-e5a0-4db3-b714-cf575b2f3e87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0613df1b-64cf-4ef4-8674-9697f0f215b5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1d1ca0c-a84a-4873-abbc-8ba25140e8c7", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "036b281c-a615-4dd2-8af9-918ea2b871fa", 0, "e315d85b-3421-4f26-84aa-40dd87b1ee9d", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "de7ab00d-df41-4007-b6fe-3d5c0e4e2f6a", false, "Vena.Venus" });
        }
    }
}
