using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cafefinder.Migrations
{
    /// <inheritdoc />
    public partial class addchilderen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Address", "Childeren", "City", "DamadArosGrim", "LocationLink", "Man", "Name", "Neighborhood", "PaksaziSorat", "Password", "Photo", "StarRating", "UserName", "Women", "WorkTime", "feshial", "kashtnakhon", "keratin", "rezerv", "selectrezerv" },
                values: new object[,]
                {
                    { new Guid("1ffb2405-0690-41a9-b6b2-a6a3867c84ef"), "بلوار سجاد ، بزرگمهر جنوبی 3", true, "mashhad", true, "https://www.mrk.co.ir", true, "آرایشگاه مردانه کامران", "ملک آباد", true, "Password", "[]", "[]", "kamran-sajad", false, "ساعت 8 الی 20", false, false, true, "[]", "{}" },
                    { new Guid("4b47c302-234b-4c50-b443-6edac4888c78"), "بلوار سجاد ، حامد شمالی 5 ", true, "mashhad", false, "https://www.mrk.co.ir", false, "سالن زیبایی ماه مریم", "حامد شمالی", true, "Password", "[]", "[]", "maryam-moon", true, "ساعت 8 الی 23", true, false, true, "[]", "{}" },
                    { new Guid("cf4201eb-db8c-4c40-ade6-d3dec94ebecc"), "بلوار سجاد ، گلریز 1", false, "mashhad", true, "https://www.mrk.co.ir", false, "سالن زیبایی آنارام", "سجاد", true, "Password", "[]", "[]", "anaram", true, "ساعت 10 الی 22", true, true, true, "[]", "{}" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Numberphone", "Password", "UserName" },
                values: new object[] { new Guid("4d065deb-4c0e-4a53-96ec-a46a61fdf6bd"), "09334101438", "cafe1403admin*", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("1ffb2405-0690-41a9-b6b2-a6a3867c84ef"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("4b47c302-234b-4c50-b443-6edac4888c78"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("cf4201eb-db8c-4c40-ade6-d3dec94ebecc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d065deb-4c0e-4a53-96ec-a46a61fdf6bd"));

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
    }
}
