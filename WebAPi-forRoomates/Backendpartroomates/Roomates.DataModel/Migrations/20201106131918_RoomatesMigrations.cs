using Microsoft.EntityFrameworkCore.Migrations;

namespace Roomates.DataModel.Migrations
{
    public partial class RoomatesMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(maxLength: 10, nullable: false),
                    QuestionForRoomate = table.Column<bool>(nullable: false),
                    Messages = table.Column<bool>(nullable: false),
                    DoYouHaveSpace = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<long>(maxLength: 10, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Age", "DoYouHaveSpace", "Email", "FullName", "Messages", "Password", "PhoneNumber", "QuestionForRoomate" },
                values: new object[] { "1", "New Address", 23, true, "viktoriajovanovska@gmail.com", "Viktorija Jovanovska", true, "`-?`;?'????F??", 707070L, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
