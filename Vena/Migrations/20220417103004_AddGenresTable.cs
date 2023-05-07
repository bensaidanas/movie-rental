using Microsoft.EntityFrameworkCore.Migrations;

namespace Vena.Migrations
{
    public partial class AddGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ab6d0a4-5291-4dbe-9583-968aaa9c3962");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5de20477-8ad6-4030-b097-0918e04a9c56");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1d1ca0c-a84a-4873-abbc-8ba25140e8c7", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "036b281c-a615-4dd2-8af9-918ea2b871fa", 0, "e315d85b-3421-4f26-84aa-40dd87b1ee9d", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "de7ab00d-df41-4007-b6fe-3d5c0e4e2f6a", false, "Vena.Venus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genres");

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
                values: new object[] { "7ab6d0a4-5291-4dbe-9583-968aaa9c3962", "1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5de20477-8ad6-4030-b097-0918e04a9c56", 0, "36b6ea17-d88e-4cd8-ac9a-0f258303d538", "AppUser", "Vena.Venus@gmail.com", false, "Venus", "Vena", false, null, null, null, null, null, false, "db4ae862-a744-4d4d-81df-d4f70bb85793", false, "Vena.Venus" });
        }
    }
}
