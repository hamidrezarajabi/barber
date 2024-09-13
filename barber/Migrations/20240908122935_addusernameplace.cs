using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cafefinder.Migrations
{
    /// <inheritdoc />
    public partial class addusernameplace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("2c5e89a3-88e2-428e-9e6f-703f2f436d15"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("75098651-364f-4b66-ad6f-650bec447fd7"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("96c29506-4ddf-4698-a978-99319ca44903"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52491717-410f-4935-a76f-397bab619c75"));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rezarv",
                table: "Places",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Address", "BirthdayTheme", "BookCafe", "CafeShop", "City", "FoodAndDrink", "FreeSittingTime", "FreeSmoke", "Link", "LocationLink", "Name", "Neighborhood", "OpenSpace", "Password", "Photo", "Restaurant", "RoofGarden", "StarRating", "UserName", "rezarv" },
                values: new object[,]
                {
                    { new Guid("07d6aad7-0601-4495-85dc-9fb758c7806e"), "وکیل آباد 13", false, false, false, "mashhad", false, "free time", false, "www.miranagency.ir", "www.miranagency.ir", " لیالی لبنان", "وکیل آباد", true, "Password", "[]", true, false, "[]", "layali-lobnan", "{}" },
                    { new Guid("4b0c979f-7e86-4fa9-a93a-cd706790cb69"), "بلوار سجاد ،چهارراه گلریز ، گلریز4،یاس3", false, true, true, "mashhad", true, "free time", true, "www.miranagency.ir", "www.miranagency.ir", "خانه اکنون", "سجاد", true, "Password", "[]", true, false, "[]", "aknon-home", "{}" },
                    { new Guid("92f37ab2-cc03-4f13-8a8f-1ce8d78937d2"), "بلوار سجاد، پاساژ لاله ، انتهای پاساژ طبقه اول", false, true, true, "mashhad", false, "45 min", true, "www.mrk.co.ir", "www.mrk.co.ir", "ماه من", "سجاد", true, "Password", "[]", false, true, "[]", "my-moon", "{}" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Numberphone", "Password", "UserName" },
                values: new object[] { new Guid("a9afdb37-ce0f-42ad-acab-fa82f6521051"), "09334101438", "cafe1403admin*", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("07d6aad7-0601-4495-85dc-9fb758c7806e"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("4b0c979f-7e86-4fa9-a93a-cd706790cb69"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("92f37ab2-cc03-4f13-8a8f-1ce8d78937d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9afdb37-ce0f-42ad-acab-fa82f6521051"));

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "rezarv",
                table: "Places");

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Address", "BirthdayTheme", "BookCafe", "CafeShop", "City", "FoodAndDrink", "FreeSittingTime", "FreeSmoke", "Link", "LocationLink", "Name", "Neighborhood", "OpenSpace", "Photo", "Restaurant", "RoofGarden", "StarRating" },
                values: new object[,]
                {
                    { new Guid("2c5e89a3-88e2-428e-9e6f-703f2f436d15"), "بلوار سجاد، پاساژ لاله ، انتهای پاساژ طبقه اول", false, true, true, "mashhad", false, "45 min", true, "www.mrk.co.ir", "www.mrk.co.ir", "ماه من", "سجاد", true, "[]", false, true, "[]" },
                    { new Guid("75098651-364f-4b66-ad6f-650bec447fd7"), "وکیل آباد 13", false, false, false, "mashhad", false, "free time", false, "www.miranagency.ir", "www.miranagency.ir", " لیالی لبنان", "وکیل آباد", true, "[]", true, false, "[]" },
                    { new Guid("96c29506-4ddf-4698-a978-99319ca44903"), "بلوار سجاد ،چهارراه گلریز ، گلریز4،یاس3", false, true, true, "mashhad", true, "free time", true, "www.miranagency.ir", "www.miranagency.ir", "خانه اکنون", "سجاد", true, "[]", true, false, "[]" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Numberphone", "Password", "UserName" },
                values: new object[] { new Guid("52491717-410f-4935-a76f-397bab619c75"), "09334101438", "cafe1403admin*", "admin" });
        }
    }
}
