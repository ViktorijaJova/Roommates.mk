using Microsoft.EntityFrameworkCore.Migrations;

namespace Roomates.DataModel.Migrations.ApartmentsDb
{
    public partial class ApartmentsMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apartment",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    Area = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<int>(maxLength: 100, nullable: false),
                    InternetAccess = table.Column<bool>(nullable: false),
                    TvAccess = table.Column<bool>(nullable: false),
                    TvOperator = table.Column<string>(nullable: false),
                    TypeOfHEating = table.Column<string>(nullable: false),
                    Rooms = table.Column<int>(maxLength: 100, nullable: false),
                    TwoSepratedBedRooms = table.Column<bool>(nullable: false),
                    BedroomsEquipped = table.Column<bool>(nullable: false),
                    Smoking = table.Column<bool>(nullable: false),
                    KitchenEqupped = table.Column<bool>(nullable: false),
                    BathEquipped = table.Column<bool>(nullable: false),
                    LivingRoomEqupped = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Apartment",
                columns: new[] { "Id", "Area", "BathEquipped", "BedroomsEquipped", "InternetAccess", "KitchenEqupped", "LivingRoomEqupped", "Name", "Password", "Price", "Rooms", "Smoking", "TvAccess", "TvOperator", "TwoSepratedBedRooms", "TypeOfHEating" },
                values: new object[] { "2", "Skopje", true, true, true, false, true, "Apartmento", "`-?`;?'????F??", 230, 4, true, true, "N/A", false, "N/A" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartment");
        }
    }
}
