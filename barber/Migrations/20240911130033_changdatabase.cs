using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cafefinder.Migrations
{
    /// <inheritdoc />
    public partial class changdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "rezarv",
                table: "Places",
                newName: "selectrezerv");

            migrationBuilder.RenameColumn(
                name: "RoofGarden",
                table: "Places",
                newName: "keratin");

            migrationBuilder.RenameColumn(
                name: "Restaurant",
                table: "Places",
                newName: "kashtnakhon");

            migrationBuilder.RenameColumn(
                name: "OpenSpace",
                table: "Places",
                newName: "feshial");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Places",
                newName: "rezerv");

            migrationBuilder.RenameColumn(
                name: "FreeSmoke",
                table: "Places",
                newName: "Women");

            migrationBuilder.RenameColumn(
                name: "FreeSittingTime",
                table: "Places",
                newName: "WorkTime");

            migrationBuilder.RenameColumn(
                name: "FoodAndDrink",
                table: "Places",
                newName: "PaksaziSorat");

            migrationBuilder.RenameColumn(
                name: "CafeShop",
                table: "Places",
                newName: "Man");

            migrationBuilder.RenameColumn(
                name: "BookCafe",
                table: "Places",
                newName: "DamadArosGrim");

            migrationBuilder.RenameColumn(
                name: "BirthdayTheme",
                table: "Places",
                newName: "Childeren");

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Address", "Childeren", "City", "DamadArosGrim", "LocationLink", "Man", "Name", "Neighborhood", "PaksaziSorat", "Password", "Photo", "StarRating", "UserName", "Women", "WorkTime", "feshial", "kashtnakhon", "keratin", "rezerv", "selectrezerv" },
                values: new object[,]
                {
                    { new Guid("3e45488a-204f-4058-9254-68ddc29c9e9f"), "بلوار سجاد ، گلریز 1", false, "mashhad", true, "https://www.mrk.co.ir", false, "سالن زیبایی آنارام", "سجاد", true, "Password", "[]", "[]", "anaram", true, "ساعت 10 الی 22", true, true, true, "[]", "{}" },
                    { new Guid("adc16299-ce5d-4dbd-9d62-bfd710c1dc36"), "بلوار سجاد ، حامد شمالی 5 ", false, "mashhad", false, "https://www.mrk.co.ir", false, "سالن زیبایی ماه مریم", "حامد شمالی", true, "Password", "[]", "[]", "maryam-moon", true, "ساعت 8 الی 23", true, false, true, "[]", "{}" },
                    { new Guid("dcbed773-1bd0-4964-ba1f-ca487b5f145d"), "بلوار سجاد ، بزرگمهر جنوبی 3", false, "mashhad", true, "https://www.mrk.co.ir", true, "آرایشگاه مردانه کامران", "ملک آباد", true, "Password", "[]", "[]", "kamran-sajad", false, "ساعت 8 الی 20", false, false, true, "[]", "{}" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Numberphone", "Password", "UserName" },
                values: new object[] { new Guid("d54b6a68-d0e4-4490-8c13-9607852c8b25"), "09334101438", "cafe1403admin*", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("3e45488a-204f-4058-9254-68ddc29c9e9f"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("adc16299-ce5d-4dbd-9d62-bfd710c1dc36"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("dcbed773-1bd0-4964-ba1f-ca487b5f145d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d54b6a68-d0e4-4490-8c13-9607852c8b25"));

            migrationBuilder.RenameColumn(
                name: "selectrezerv",
                table: "Places",
                newName: "rezarv");

            migrationBuilder.RenameColumn(
                name: "rezerv",
                table: "Places",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "keratin",
                table: "Places",
                newName: "RoofGarden");

            migrationBuilder.RenameColumn(
                name: "kashtnakhon",
                table: "Places",
                newName: "Restaurant");

            migrationBuilder.RenameColumn(
                name: "feshial",
                table: "Places",
                newName: "OpenSpace");

            migrationBuilder.RenameColumn(
                name: "WorkTime",
                table: "Places",
                newName: "FreeSittingTime");

            migrationBuilder.RenameColumn(
                name: "Women",
                table: "Places",
                newName: "FreeSmoke");

            migrationBuilder.RenameColumn(
                name: "PaksaziSorat",
                table: "Places",
                newName: "FoodAndDrink");

            migrationBuilder.RenameColumn(
                name: "Man",
                table: "Places",
                newName: "CafeShop");

            migrationBuilder.RenameColumn(
                name: "DamadArosGrim",
                table: "Places",
                newName: "BookCafe");

            migrationBuilder.RenameColumn(
                name: "Childeren",
                table: "Places",
                newName: "BirthdayTheme");

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
    }
}
