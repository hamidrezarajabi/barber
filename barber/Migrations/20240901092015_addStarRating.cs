using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cafefinder.Migrations
{
    /// <inheritdoc />
    public partial class addStarRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StarRating",
                table: "Places",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StarRating",
                table: "Places");
        }
    }
}
