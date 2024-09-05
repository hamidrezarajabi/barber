using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cafefinder.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CafeShop = table.Column<bool>(type: "bit", nullable: false),
                    Restaurant = table.Column<bool>(type: "bit", nullable: false),
                    FreeSmoke = table.Column<bool>(type: "bit", nullable: false),
                    FoodAndDrink = table.Column<bool>(type: "bit", nullable: false),
                    OpenSpace = table.Column<bool>(type: "bit", nullable: false),
                    FreeSittingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoofGarden = table.Column<bool>(type: "bit", nullable: false),
                    BookCafe = table.Column<bool>(type: "bit", nullable: false),
                    BirthdayTheme = table.Column<bool>(type: "bit", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numberphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
