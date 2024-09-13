using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cafefinder.Migrations
{
    /// <inheritdoc />
    public partial class list : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Address", "BirthdayTheme", "BookCafe", "CafeShop", "City", "FoodAndDrink", "FreeSittingTime", "FreeSmoke", "Link", "LocationLink", "Name", "Neighborhood", "OpenSpace", "Password", "Photo", "Restaurant", "RoofGarden", "StarRating", "UserName", "rezarv" },
                values: new object[,]
                {
                    { new Guid("7f517546-a966-4101-9d17-ef00935fd58d"), "بلوار سجاد ،چهارراه گلریز ، گلریز4،یاس3", false, true, true, "mashhad", true, "free time", true, "www.miranagency.ir", "www.miranagency.ir", "خانه اکنون", "سجاد", true, "Password", "[]", true, false, "[]", "aknon-home", "[]" },
                    { new Guid("c820f753-b297-41a4-bb43-330d1c2a62ad"), "وکیل آباد 13", false, false, false, "mashhad", false, "free time", false, "www.miranagency.ir", "www.miranagency.ir", " لیالی لبنان", "وکیل آباد", true, "Password", "[]", true, false, "[]", "layali-lobnan", "[]" },
                    { new Guid("eb61c50e-0af4-42d0-a3c9-66b859aef8fe"), "بلوار سجاد، پاساژ لاله ، انتهای پاساژ طبقه اول", false, true, true, "mashhad", false, "45 min", true, "www.mrk.co.ir", "www.mrk.co.ir", "ماه من", "سجاد", true, "Password", "[]", false, true, "[]", "my-moon", "[]" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Numberphone", "Password", "UserName" },
                values: new object[] { new Guid("658c51e8-0114-4f28-98f4-dc273fcb5f9e"), "09334101438", "cafe1403admin*", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("7f517546-a966-4101-9d17-ef00935fd58d"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("c820f753-b297-41a4-bb43-330d1c2a62ad"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("eb61c50e-0af4-42d0-a3c9-66b859aef8fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("658c51e8-0114-4f28-98f4-dc273fcb5f9e"));

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
    }
}
