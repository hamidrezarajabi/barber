using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cafefinder.Migrations
{
    /// <inheritdoc />
    public partial class adduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("21a726c9-b641-4ef5-b3f4-0dfd9561c71e"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("e0421776-f722-4716-963b-9462c3534e7b"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("e5edb3aa-7b4d-484d-bf4e-a266b6cb0d01"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Address", "BirthdayTheme", "BookCafe", "CafeShop", "City", "FoodAndDrink", "FreeSittingTime", "FreeSmoke", "Link", "LocationLink", "Name", "Neighborhood", "OpenSpace", "Photo", "Restaurant", "RoofGarden", "StarRating" },
                values: new object[,]
                {
                    { new Guid("21a726c9-b641-4ef5-b3f4-0dfd9561c71e"), "بلوار سجاد ،چهارراه گلریز ، گلریز4،یاس3", false, true, true, "mashhad", true, "free time", true, "www.miranagency.ir", "www.miranagency.ir", "خانه اکنون", "سجاد", true, "[]", true, false, "[]" },
                    { new Guid("e0421776-f722-4716-963b-9462c3534e7b"), "بلوار سجاد، پاساژ لاله ، انتهای پاساژ طبقه اول", false, true, true, "mashhad", false, "45 min", true, "www.mrk.co.ir", "www.mrk.co.ir", "ماه من", "سجاد", true, "[]", false, true, "[]" },
                    { new Guid("e5edb3aa-7b4d-484d-bf4e-a266b6cb0d01"), "وکیل آباد 13", false, false, false, "mashhad", false, "free time", false, "www.miranagency.ir", "www.miranagency.ir", " لیالی لبنان", "وکیل آباد", true, "[]", true, false, "[]" }
                });
        }
    }
}
