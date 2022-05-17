using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Suchimu.Server.Migrations
{
    public partial class Update_studio_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Studios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Studios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 993, DateTimeKind.Local).AddTicks(5712), new DateTime(2022, 5, 11, 21, 45, 23, 996, DateTimeKind.Local).AddTicks(612), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(474), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(508), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(610), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(667), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(670), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1058), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1064), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1157), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1162), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1241), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1246), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1319), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1323), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1398), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1403), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1496), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1502), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1688), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1770), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1775), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1846), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1851), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1935), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(1940), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2027), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2029), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2227), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2230), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2309), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2398), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2404), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2560), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2562), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2735), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2739), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2799), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2849), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2851), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2900), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2903), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2956), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(2961), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3016), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3019), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3165), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3171), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3226), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3231), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3295), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3300), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3386), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3390), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3461), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3467), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3614), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3672), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3675), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3727), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3729), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3797), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3803), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3878), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4018), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4020), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4074), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4079), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4185), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4313), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4318), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4376), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4380), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4556), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4565), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4640), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4645), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4721), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4800), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4807), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4885), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4891), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4963), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(4968), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5226), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5308), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5312), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5388), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5389), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5466), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5542), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5545), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5723), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5729), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5807), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5811), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5890), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5894), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(5974), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6048), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6053), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6236), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6319), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6324), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6376), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6378), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6433), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6436), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6481), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6528), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6674), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6680), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6735), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6740), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6799), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6861), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7018), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7086), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7093), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7147), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7204), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7206), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7265), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7271), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7350), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7355), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7512), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7570), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7577), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7631), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7636), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7712), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7715), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7794), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7799), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7989), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(7997), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8070), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8079), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8157), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8162), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8234), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8315), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8502), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8508), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8584), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8590), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8678), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8755), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8760), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8835), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8922), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9214), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9216), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9295), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9301), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9378), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9384), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9463), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9545), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9550), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9689), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9694), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9738), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9787), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9789), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9840), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9844), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9903), new DateTime(2022, 5, 11, 21, 45, 23, 997, DateTimeKind.Local).AddTicks(9908), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(42), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(48), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(111), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(116), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(185), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(190), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(247), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(250), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(306), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(309), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(359), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(361), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(523), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(529), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(602), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(653), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(655), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(704), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(706), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(765), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(770), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(931), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(938), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1015), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1021), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1099), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1103), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1180), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1187), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1273), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1275), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1537), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1612), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1617), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1695), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1700), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1776), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1781), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1858), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(1860), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2059), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2064), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2135), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2216), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2218), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2293), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2299), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2375), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2377), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2556), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2562), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2640), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2715), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2723), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2788), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2790), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2961), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(2963), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3009), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3015), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3085), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3143), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3147), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3207), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3212), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3368), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3371), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3432), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3434), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3485), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3488), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3540), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3545), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3628), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3634), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3705), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3708), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3841), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3844), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3913), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3915), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3994), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(3999), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4079), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4192), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4194), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4379), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4386), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4456), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4541), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4543), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4614), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4621), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4698), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4887), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4969), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(4975), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5053), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5061), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5143), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5226), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5232), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5312), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5317), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5512), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5519), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5602), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5607), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5675), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5761), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5822), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5951), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(5954), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6135), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6137), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6182), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6238), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6240), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6293), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6296), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6441), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6447), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6512), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6595), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6653), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6658), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6719), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6722), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6777), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(6780), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7034), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7042), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7099), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7101), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7154), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7211), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7283), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7288), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7479), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7486), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7568), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7573), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7651), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7656), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7730), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7816), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(7821), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8105), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8107), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8183), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8187), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8270), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8272), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8354), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8438), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8717), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8804), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8810), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8884), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8887), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(8975), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9052), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9059), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9257), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9260), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9336), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9338), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9394), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9396), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9448), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9451), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9501), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9503), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9653), new DateTime(2022, 5, 11, 21, 45, 23, 998, DateTimeKind.Local).AddTicks(9660), 4 });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Name", "Url" },
                values: new object[] { "https://slotcatalog.com/userfiles/image/brand/Konami_m.jpg", "Konami", "studio_konami" });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Url" },
                values: new object[] { "https://slotcatalog.com/userfiles/image/brand/Konami_m.jpg", "studio_nintendo" });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Url" },
                values: new object[] { "https://slotcatalog.com/userfiles/image/brand/Konami_m.jpg", "studio_sega" });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Url" },
                values: new object[] { "https://slotcatalog.com/userfiles/image/brand/Konami_m.jpg", "studio_bankai_namco" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Studios");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Studios");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 903, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(2411), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7532), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7542), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7777), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7779), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7817), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7819), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7865), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7867), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7905), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7907), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7947), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7949), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8051), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8052), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8097), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8099), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8143), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8184), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8186), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8224), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8226), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8334), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8336), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8380), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8381), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8418), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8420), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8456), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8496), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8498), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8539), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8629), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8630), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8666), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8667), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8702), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8739), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8741), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8777), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8912), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8913), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8949), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8951), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8989), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8991), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9025), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9027), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9062), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9064), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9164), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9201), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9202), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9278), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9280), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9321), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9322), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9409), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9410), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9445), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9483), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9485), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9522), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9523), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9560), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9601), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9687), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9688), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9726), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9728), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9764), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9765), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9803), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9840), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9841), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9928), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9929), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9965), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9967), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(42), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(43), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(82), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(169), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(208), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(210), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(245), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(247), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(285), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(286), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(322), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(324), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(359), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(361), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(446), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(448), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(483), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(521), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(523), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(559), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(561), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(597), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(599), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(685), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(723), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(760), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(762), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(800), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(837), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(971), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1009), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1046), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1048), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1082), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1120), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1121), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1205), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1207), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1244), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1245), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1281), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1316), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1318), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1352), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1354), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1438), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1439), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1476), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1478), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1515), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1517), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1555), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1590), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1591), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1626), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1713), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1750), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1752), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1789), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1790), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1826), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1828), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1862), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1863), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1986), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2022), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2023), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2057), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2059), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2093), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2095), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2179), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2180), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2216), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2218), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2251), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2252), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2286), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2323), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2325), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2361), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2362), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2449), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2451), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2484), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2485), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2522), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2523), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2561), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2562), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2599), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2601), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2688), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2689), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2724), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2725), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2762), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2799), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2833), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2835), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2945), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2981), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2983), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3019), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3021), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3058), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3059), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3094), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3096), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3133), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3243), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3244), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3283), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3320), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3357), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3358), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3393), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3477), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3479), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3514), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3515), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3551), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3552), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3587), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3624), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3626), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3709), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3711), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3747), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3749), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3785), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3786), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3822), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3859), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3969), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3971), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4006), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4008), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4043), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4045), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4078), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4080), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4114), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4115), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4199), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4200), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4236), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4238), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4273), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4274), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4312), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4345), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4346), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4431), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4433), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4468), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4470), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4505), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4507), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4541), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4542), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4576), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4577), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4660), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4696), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4698), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4734), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4736), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4772), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4809), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4811), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4845), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4847), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4980), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5016), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5052), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5087), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5089), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5124), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5214), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5247), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5248), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5281), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5283), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5319), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5320), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5356), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5463), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5502), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5536), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5537), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5573), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5575), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5608), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5646), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5731), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5733), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5768), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5770), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5804), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5838), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5839), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5872), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5874), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5959), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5960), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5994), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5995), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6033), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6034), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6068), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6070), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6106), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6145), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6231), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6233), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6267), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6269), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6304), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6305), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6341), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6342), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6377), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6465), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6467), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6502), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6539), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6540), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6576), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6577), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6612), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6614), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6697), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6733), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6806), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6808), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6842), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6843), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6881), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6882), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6999), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7001), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7033), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7034), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7069), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7071), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7106), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7108), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7142), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7143), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7231), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7232), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7268), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7270), 2 });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Konammi");
        }
    }
}
