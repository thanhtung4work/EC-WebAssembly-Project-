using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Suchimu.Server.Migrations
{
    public partial class Seeding_v101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryUrl",
                table: "Games");

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7532), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7597), 2 });

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
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7817), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7819), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7865), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7867), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7905), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7907), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7947), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(7949) });

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
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8143), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8144), 2 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8224), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8334), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8336) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8418), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8420), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8456), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8458), 3 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8539), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8541), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8629), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8630), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8666), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8702), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8703), 3 });

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
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8777), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8912), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8913), 2 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8989), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(8991), 3 });

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
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9242), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9278), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9280), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9321), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9322) });

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
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9445), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9446), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9483), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9485) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9560), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9562), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9601), 4 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9726), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9728) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9803), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9805), 3 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9965), new DateTime(2022, 5, 10, 21, 46, 25, 904, DateTimeKind.Local).AddTicks(9967) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(208), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(210), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(245), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(247) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(483), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(485), 3 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(597), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(685), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(687), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(723), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(760), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(762), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(837), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(839), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(971), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(973), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1009), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1010), 1 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1120), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1205), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1207) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1281), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1282), 1 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1352), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1354) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1555), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1590), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1591), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1626), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1628), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1713), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1715), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1750), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1752) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1862), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1863) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1986), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(1988), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2022), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2057), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2093), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2095), 2 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2286), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2287), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2323), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2361), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2362) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2688), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2689), 2 });

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
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2762), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2799), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2801), 2 });

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
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(2945) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3283), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3285), 4 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3357), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3393), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3477), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3514), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3551), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3552), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3587), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3589), 2 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3785), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3786), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3822), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3824), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(3859) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4006), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4043), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4045) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4114), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4115) });

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
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4236), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4238), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4273), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4274) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4576), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4577), 1 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4772), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4774), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4809), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4845), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4847), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4980), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(4981), 1 });

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
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5124), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5214), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5247), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5281), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5283), 1 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5502), 3 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5608), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5610), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5646) });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5768), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5770), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5804), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5806), 1 });

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
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5959), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5994), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6033), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6034), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6068), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6106), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6108), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6145), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6146), 2 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6267), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6304), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6305), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6341), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6342), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6377), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6379), 4 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6502), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6504), 3 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6612), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6614), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6697), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6699), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6733), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6735), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6772), 3 });

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
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6881), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(6882), 3 });

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
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7106), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7108), 2 });

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
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7231), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7232), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7268), new DateTime(2022, 5, 10, 21, 46, 25, 905, DateTimeKind.Local).AddTicks(7270), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryUrl",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 32, DateTimeKind.Local).AddTicks(8631), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(1257), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6035), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6259), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6261), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6301), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6338), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6339), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6386), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6388), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6426), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6428), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6515), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6553), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6555), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6595), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6597), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6636), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6638), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6676), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6678), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6765), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6805), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6843), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6845), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6879), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6881), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6917), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6919), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7011), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7013), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7051), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7053), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7089), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7091), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7127), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7167), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7169), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7257), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7259), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7297), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7298), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7336), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7338), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7375), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7376), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7411), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7413), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7503), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7505), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7542), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7544), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7579), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7580), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7616), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7618), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7652), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7654), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7741), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7743), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7782), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7823), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7824), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7861), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7862), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7896), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7988), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7990), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8053), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8054), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8091), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8092), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8130), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8132), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8170), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8284), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8286), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8321), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8323), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8357), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8359), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8395), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8397), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8431), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8559), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8560), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8597), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8599), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8634), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8672), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8673), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8709), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8796), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8798), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8833), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8835), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8871), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8906), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8908), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8941), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8942), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9027), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9028), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9066), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9068), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9101), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9136), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9138), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9173), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9262), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9264), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9299), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9337), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9339), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9376), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9377), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9463), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9465), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9499), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9501), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9535), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9571), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9609), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9698), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9699), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9735), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9737), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9773), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9774), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9811), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9849), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9851), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9887), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9889), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9979), new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9981), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(16), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(17), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(53), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(55), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(91), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(93), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(127), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(129), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(238), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(277), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(279), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(316), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(317), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(353), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(391), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(478), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(480), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(514), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(550), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(589), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(591), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(626), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(628), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(715), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(717), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(751), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(752), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(787), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(789), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(823), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(860), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(947), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(949), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(984), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(985), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1020), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1022), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1057), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1059), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1096), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1097), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1182), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1184), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1219), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1221), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1256), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1257), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1291), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1293), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1327), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1329), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1414), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1446), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1448), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1482), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1483), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1517), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1518), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1554), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1556), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1639), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1641), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1676), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1678), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1713), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1715), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1750), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1785), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1820), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1822), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1909), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1984), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1985), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2021), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2023), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2059), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2061), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2168), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2170), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2204), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2206), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2239), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2241), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2276), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2278), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2314), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2404), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2406), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2441), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2478), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2513), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2514), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2598), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2635), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2636), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2669), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2670), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2703), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2739), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2741), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2827), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2829), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2864), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2866), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2902), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2904), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2941), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2978), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2980), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3066), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3068), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3103), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3139), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3141), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3177), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3179), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3212), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3214), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3301), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3340), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3342), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3376), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3377), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3451), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3453), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3537), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3539), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3574), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3610), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3612), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3646), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3681), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3683), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3765), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3767), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3806), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3842), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3878), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3880), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3916), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3918), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4022), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4024), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4065), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4067), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4101), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4136), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4138), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4170), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4172), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4206), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4208), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4292), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4294), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4327), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4329), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4363), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4399), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4436), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4438), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4523), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4558), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4560), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4596), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4598), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4632), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4633), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4667), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4751), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4753), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4790), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4792), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4826), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4828), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4861), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4862), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4898), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4900), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4982), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4984), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5019), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5020), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5058), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5059), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5095), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5096), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5133), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5134), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5221), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 4, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5256), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5257), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5293), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5295), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5329), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5331), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5367), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5368), 3 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 5, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5451), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5453), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 1, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5486), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5487), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5526), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5528), 4 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 3, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5563), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5565), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CategoryId", "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { 2, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5601), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5603), 2 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreateDate", "LatestUpdate", "StudioId" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5687), new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5689), 1 });
        }
    }
}
