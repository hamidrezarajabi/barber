using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cafefinder.Migrations
{
    /// <inheritdoc />
    public partial class coments2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("6b797993-efe1-46fa-a18d-070f31509655"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("780c7e29-bcb3-4b8f-a5bf-8b6ec167920d"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("932fc171-3c85-44a5-a86f-de7be3d544cb"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("6b797993-efe1-46fa-a18d-070f31509655"), "وکیل آباد 13", false, false, false, "mashhad", false, "free time", false, "www.miranagency.ir", "www.miranagency.ir", " لیالی لبنان", "وکیل آباد", true, "[]", true, false, "{}" },
                    { new Guid("780c7e29-bcb3-4b8f-a5bf-8b6ec167920d"), "بلوار سجاد، پاساژ لاله ، انتهای پاساژ طبقه اول", false, true, true, "mashhad", false, "45 min", true, "www.mrk.co.ir", "www.mrk.co.ir", "ماه من", "سجاد", true, "[]", false, true, "{}" },
                    { new Guid("932fc171-3c85-44a5-a86f-de7be3d544cb"), "بلوار سجاد ،چهارراه گلریز ، گلریز4،یاس3", false, true, true, "mashhad", true, "free time", true, "www.miranagency.ir", "www.miranagency.ir", "خانه اکنون", "سجاد", true, "[]", true, false, "{}" }
                });
        }
    }
}
