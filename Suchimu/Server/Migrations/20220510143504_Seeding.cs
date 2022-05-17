using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Suchimu.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Game Category 1", "game-category-1" },
                    { 2, "Game Category 2", "game-category-2" },
                    { 3, "Game Category 3", "game-category-3" },
                    { 4, "Game Category 4", "game-category-4" },
                    { 5, "Game Category 5", "game-category-5" }
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "Email", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "contact@konami.com", "Japan", "Konammi" },
                    { 2, "contact@nintendo.com", "Japan", "Nintendo" },
                    { 3, "contact@sega.com", "Japan", "SEGA" },
                    { 4, "contact@bankai_namco.com", "Japan", "Bankai Namco" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CategoryUrl", "CreateDate", "Description", "ImageUrl", "IsActive", "LatestUpdate", "OriginalPrice", "Price", "ShortDescription", "StudioId", "Title" },
                values: new object[,]
                {
                    { 2, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6035), "Do you know what a CD No.2 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6045), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 2" },
                    { 126, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2204), "Do you know what a CD No.126 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2206), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 126" },
                    { 127, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2239), "Do you know what a CD No.127 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2241), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 127" },
                    { 140, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2864), "Do you know what a CD No.140 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2866), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 140" },
                    { 141, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2902), "Do you know what a CD No.141 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2904), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 141" },
                    { 144, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3066), "Do you know what a CD No.144 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3068), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 144" },
                    { 156, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3610), "Do you know what a CD No.156 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3612), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 156" },
                    { 157, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3646), "Do you know what a CD No.157 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3648), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 157" },
                    { 158, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3681), "Do you know what a CD No.158 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3683), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 158" },
                    { 167, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4136), "Do you know what a CD No.167 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4138), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 167" },
                    { 169, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4206), "Do you know what a CD No.169 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4208), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 169" },
                    { 175, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4523), "Do you know what a CD No.175 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4524), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 175" },
                    { 176, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4558), "Do you know what a CD No.176 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4560), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 176" },
                    { 177, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4596), "Do you know what a CD No.177 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4598), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 177" },
                    { 179, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4667), "Do you know what a CD No.179 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4668), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 179" },
                    { 180, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4751), "Do you know what a CD No.180 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4753), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 180" },
                    { 183, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4861), "Do you know what a CD No.183 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4862), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 183" },
                    { 191, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5256), "Do you know what a CD No.191 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5257), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 191" },
                    { 194, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5367), "Do you know what a CD No.194 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5368), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 194" },
                    { 10, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6595), "Do you know what a CD No.10 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6597), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 10" },
                    { 13, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6765), "Do you know what a CD No.13 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6767), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 13" },
                    { 16, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6879), "Do you know what a CD No.16 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6881), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 16" },
                    { 125, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2168), "Do you know what a CD No.125 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2170), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 125" },
                    { 28, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7503), "Do you know what a CD No.28 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7505), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 28" },
                    { 124, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2059), "Do you know what a CD No.124 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2061), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 124" },
                    { 120, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1909), "Do you know what a CD No.120 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1911), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 120" },
                    { 11, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6636), "Do you know what a CD No.11 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6638), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 11" },
                    { 19, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7051), "Do you know what a CD No.19 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7053), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 19" },
                    { 32, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7652), "Do you know what a CD No.32 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7654), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 32" },
                    { 33, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7741), "Do you know what a CD No.33 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7743), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 33" },
                    { 39, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8053), "Do you know what a CD No.39 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8054), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 39" },
                    { 43, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8284), "Do you know what a CD No.43 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8286), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 43" },
                    { 57, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8906), "Do you know what a CD No.57 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8908), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 57" },
                    { 61, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9101), "Do you know what a CD No.61 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9102), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 61" },
                    { 63, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9173), "Do you know what a CD No.63 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9175), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 63" },
                    { 67, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9376), "Do you know what a CD No.67 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9377), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 67" },
                    { 75, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9773), "Do you know what a CD No.75 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9774), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 75" },
                    { 86, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(316), "Do you know what a CD No.86 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(317), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 86" },
                    { 90, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(514), "Do you know what a CD No.90 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(516), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 90" },
                    { 99, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(947), "Do you know what a CD No.99 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(949), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 99" },
                    { 103, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1096), "Do you know what a CD No.103 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1097), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 103" },
                    { 104, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1182), "Do you know what a CD No.104 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1184), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 104" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CategoryUrl", "CreateDate", "Description", "ImageUrl", "IsActive", "LatestUpdate", "OriginalPrice", "Price", "ShortDescription", "StudioId", "Title" },
                values: new object[,]
                {
                    { 111, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1482), "Do you know what a CD No.111 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1483), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 111" },
                    { 113, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1554), "Do you know what a CD No.113 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1556), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 113" },
                    { 114, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1639), "Do you know what a CD No.114 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1641), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 114" },
                    { 115, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1676), "Do you know what a CD No.115 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1678), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 115" },
                    { 118, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1785), "Do you know what a CD No.118 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1786), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 118" },
                    { 121, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1947), "Do you know what a CD No.121 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1948), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 121" },
                    { 9, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6553), "Do you know what a CD No.9 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6555), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 9" },
                    { 29, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7542), "Do you know what a CD No.29 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7544), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 29" },
                    { 36, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7861), "Do you know what a CD No.36 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7862), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 36" },
                    { 129, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2314), "Do you know what a CD No.129 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2315), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 129" },
                    { 131, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2441), "Do you know what a CD No.131 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2443), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 131" },
                    { 132, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2478), "Do you know what a CD No.132 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2479), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 132" },
                    { 135, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2635), "Do you know what a CD No.135 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2636), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 135" },
                    { 138, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2739), "Do you know what a CD No.138 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2741), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 138" },
                    { 139, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2827), "Do you know what a CD No.139 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2829), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 139" },
                    { 142, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2940), "Do you know what a CD No.142 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2941), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 142" },
                    { 145, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3103), "Do you know what a CD No.145 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3104), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 145" },
                    { 146, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3139), "Do you know what a CD No.146 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3141), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 146" },
                    { 150, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3340), "Do you know what a CD No.150 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3342), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 150" },
                    { 151, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3376), "Do you know what a CD No.151 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3377), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 151" },
                    { 153, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3451), "Do you know what a CD No.153 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3453), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 153" },
                    { 154, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3537), "Do you know what a CD No.154 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3539), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 154" },
                    { 155, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3574), "Do you know what a CD No.155 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3576), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 155" },
                    { 159, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3765), "Do you know what a CD No.159 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3767), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 159" },
                    { 163, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3916), "Do you know what a CD No.163 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3918), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 163" },
                    { 164, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4022), "Do you know what a CD No.164 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4024), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 164" },
                    { 172, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4363), "Do you know what a CD No.172 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4365), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 172" },
                    { 184, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4898), "Do you know what a CD No.184 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4900), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 184" },
                    { 187, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5058), "Do you know what a CD No.187 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5059), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 187" },
                    { 190, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5220), "Do you know what a CD No.190 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5221), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 190" },
                    { 108, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1327), "Do you know what a CD No.108 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1329), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 108" },
                    { 35, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7823), "Do you know what a CD No.35 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7824), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 35" },
                    { 107, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1291), "Do you know what a CD No.107 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1293), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 107" },
                    { 105, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1219), "Do you know what a CD No.105 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1221), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 105" },
                    { 42, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8170), "Do you know what a CD No.42 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8171), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 42" },
                    { 45, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8357), "Do you know what a CD No.45 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8359), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 45" },
                    { 46, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8395), "Do you know what a CD No.46 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8397), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 46" },
                    { 49, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8559), "Do you know what a CD No.49 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8560), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 49" },
                    { 50, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8597), "Do you know what a CD No.50 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8599), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 50" },
                    { 54, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8796), "Do you know what a CD No.54 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8798), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 54" },
                    { 58, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8941), "Do you know what a CD No.58 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8942), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 58" },
                    { 59, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9027), "Do you know what a CD No.59 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9028), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 59" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CategoryUrl", "CreateDate", "Description", "ImageUrl", "IsActive", "LatestUpdate", "OriginalPrice", "Price", "ShortDescription", "StudioId", "Title" },
                values: new object[,]
                {
                    { 66, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9337), "Do you know what a CD No.66 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9339), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 66" },
                    { 71, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9571), "Do you know what a CD No.71 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9573), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 71" },
                    { 72, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9609), "Do you know what a CD No.72 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9611), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 72" },
                    { 82, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(91), "Do you know what a CD No.82 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(93), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 82" },
                    { 83, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(127), "Do you know what a CD No.83 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(129), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 83" },
                    { 84, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(238), "Do you know what a CD No.84 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(240), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 84" },
                    { 85, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(277), "Do you know what a CD No.85 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(279), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 85" },
                    { 87, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(353), "Do you know what a CD No.87 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(355), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 87" },
                    { 89, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(478), "Do you know what a CD No.89 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(480), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 89" },
                    { 92, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(589), "Do you know what a CD No.92 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(591), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 92" },
                    { 100, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(984), "Do you know what a CD No.100 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(985), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 100" },
                    { 101, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1020), "Do you know what a CD No.101 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1022), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 101" },
                    { 102, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1057), "Do you know what a CD No.102 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1059), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 102" },
                    { 106, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1256), "Do you know what a CD No.106 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1257), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 106" },
                    { 8, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6515), "Do you know what a CD No.8 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6517), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 3, "Deez nutz 8" },
                    { 199, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5601), "Do you know what a CD No.199 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5603), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 199" },
                    { 195, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5451), "Do you know what a CD No.195 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5453), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 195" },
                    { 80, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(16), "Do you know what a CD No.80 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(17), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 80" },
                    { 91, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(550), "Do you know what a CD No.91 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(552), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 91" },
                    { 93, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(626), "Do you know what a CD No.93 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(628), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 93" },
                    { 94, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(715), "Do you know what a CD No.94 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(717), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 94" },
                    { 96, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(787), "Do you know what a CD No.96 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(789), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 96" },
                    { 97, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(823), "Do you know what a CD No.97 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(825), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 97" },
                    { 98, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(860), "Do you know what a CD No.98 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(861), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 98" },
                    { 109, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1414), "Do you know what a CD No.109 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1416), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 109" },
                    { 110, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1446), "Do you know what a CD No.110 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1448), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 110" },
                    { 112, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1517), "Do you know what a CD No.112 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1518), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 112" },
                    { 117, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1750), "Do you know what a CD No.117 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1752), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 117" },
                    { 119, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1820), "Do you know what a CD No.119 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1822), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 119" },
                    { 122, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1984), "Do you know what a CD No.122 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1985), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 122" },
                    { 123, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2021), "Do you know what a CD No.123 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2023), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 123" },
                    { 128, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2276), "Do you know what a CD No.128 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2278), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 128" },
                    { 130, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2404), "Do you know what a CD No.130 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2406), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 130" },
                    { 134, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2598), "Do you know what a CD No.134 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2599), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 134" },
                    { 137, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2703), "Do you know what a CD No.137 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2704), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 137" },
                    { 143, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2978), "Do you know what a CD No.143 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2980), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 143" },
                    { 147, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3177), "Do you know what a CD No.147 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3179), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 147" },
                    { 160, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3806), "Do you know what a CD No.160 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3808), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 160" },
                    { 79, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9979), "Do you know what a CD No.79 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9981), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 79" },
                    { 161, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3842), "Do you know what a CD No.161 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3844), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 161" },
                    { 78, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9887), "Do you know what a CD No.78 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9889), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 78" },
                    { 70, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9535), "Do you know what a CD No.70 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9536), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 70" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CategoryUrl", "CreateDate", "Description", "ImageUrl", "IsActive", "LatestUpdate", "OriginalPrice", "Price", "ShortDescription", "StudioId", "Title" },
                values: new object[,]
                {
                    { 3, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6259), "Do you know what a CD No.3 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6261), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 3" },
                    { 4, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6300), "Do you know what a CD No.4 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6301), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 4" },
                    { 6, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6386), "Do you know what a CD No.6 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6388), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 6" },
                    { 7, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6426), "Do you know what a CD No.7 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6428), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 7" },
                    { 15, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6843), "Do you know what a CD No.15 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6845), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 15" },
                    { 20, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7089), "Do you know what a CD No.20 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7091), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 20" },
                    { 21, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7127), "Do you know what a CD No.21 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7129), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 21" },
                    { 22, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7167), "Do you know what a CD No.22 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7169), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 22" },
                    { 24, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7297), "Do you know what a CD No.24 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7298), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 24" },
                    { 25, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7336), "Do you know what a CD No.25 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7338), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 25" },
                    { 26, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7375), "Do you know what a CD No.26 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7376), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 26" },
                    { 30, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7579), "Do you know what a CD No.30 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7580), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 30" },
                    { 37, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7896), "Do you know what a CD No.37 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7898), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 37" },
                    { 38, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7988), "Do you know what a CD No.38 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7990), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 38" },
                    { 40, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8091), "Do you know what a CD No.40 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8092), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 40" },
                    { 44, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8321), "Do you know what a CD No.44 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8323), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 44" },
                    { 48, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8520), "Do you know what a CD No.48 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8522), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 48" },
                    { 51, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8634), "Do you know what a CD No.51 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8636), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 51" },
                    { 56, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8869), "Do you know what a CD No.56 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8871), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 56" },
                    { 60, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9066), "Do you know what a CD No.60 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9068), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 60" },
                    { 62, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9136), "Do you know what a CD No.62 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9138), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 62" },
                    { 76, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9811), "Do you know what a CD No.76 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9812), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 76" },
                    { 165, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4065), "Do you know what a CD No.165 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4067), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 165" },
                    { 170, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4292), "Do you know what a CD No.170 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4294), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 170" },
                    { 171, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4327), "Do you know what a CD No.171 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4329), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 171" },
                    { 73, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9698), "Do you know what a CD No.73 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9699), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 73" },
                    { 74, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9735), "Do you know what a CD No.74 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9737), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 74" },
                    { 77, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9849), "Do you know what a CD No.77 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9851), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 77" },
                    { 81, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(53), "Do you know what a CD No.81 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(55), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 81" },
                    { 88, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(391), "Do you know what a CD No.88 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(393), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 88" },
                    { 95, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(751), "Do you know what a CD No.95 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(752), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 95" },
                    { 116, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1713), "Do you know what a CD No.116 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(1715), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 116" },
                    { 133, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2513), "Do you know what a CD No.133 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2514), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 133" },
                    { 136, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2669), "Do you know what a CD No.136 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(2670), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 136" },
                    { 148, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3212), "Do you know what a CD No.148 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3214), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 148" },
                    { 149, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3301), "Do you know what a CD No.149 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3305), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 149" },
                    { 152, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3413), "Do you know what a CD No.152 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3414), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 152" },
                    { 162, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3878), "Do you know what a CD No.162 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(3880), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 162" },
                    { 166, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4101), "Do you know what a CD No.166 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4103), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 166" },
                    { 168, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4170), "Do you know what a CD No.168 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4172), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 168" },
                    { 173, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4399), "Do you know what a CD No.173 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4401), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 173" },
                    { 174, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4436), "Do you know what a CD No.174 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4438), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 174" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CategoryUrl", "CreateDate", "Description", "ImageUrl", "IsActive", "LatestUpdate", "OriginalPrice", "Price", "ShortDescription", "StudioId", "Title" },
                values: new object[,]
                {
                    { 178, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4632), "Do you know what a CD No.178 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4633), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 178" },
                    { 181, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4790), "Do you know what a CD No.181 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4792), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 181" },
                    { 188, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5095), "Do you know what a CD No.188 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5096), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 188" },
                    { 192, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5293), "Do you know what a CD No.192 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5295), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 192" },
                    { 69, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9499), "Do you know what a CD No.69 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9501), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 69" },
                    { 68, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9463), "Do you know what a CD No.68 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9465), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 68" },
                    { 65, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9299), "Do you know what a CD No.65 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9301), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 65" },
                    { 64, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9262), "Do you know what a CD No.64 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(9264), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 64" },
                    { 182, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4826), "Do you know what a CD No.182 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4828), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 182" },
                    { 185, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4982), "Do you know what a CD No.185 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(4984), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 185" },
                    { 186, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5019), "Do you know what a CD No.186 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5020), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 186" },
                    { 189, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5133), "Do you know what a CD No.189 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5134), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 189" },
                    { 196, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5486), "Do you know what a CD No.196 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5487), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 196" },
                    { 198, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5563), "Do you know what a CD No.198 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5565), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 198" },
                    { 200, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5687), "Do you know what a CD No.200 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5689), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 1, "Deez nutz 200" },
                    { 1, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 32, DateTimeKind.Local).AddTicks(8631), "Do you know what a CD No.1 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(1257), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 1" },
                    { 5, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6338), "Do you know what a CD No.5 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6339), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 5" },
                    { 12, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6676), "Do you know what a CD No.12 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6678), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 12" },
                    { 193, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5329), "Do you know what a CD No.193 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5331), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 193" },
                    { 14, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6805), "Do you know what a CD No.14 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6807), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 14" },
                    { 18, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7011), "Do you know what a CD No.18 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7013), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 18" },
                    { 23, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7257), "Do you know what a CD No.23 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7259), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 23" },
                    { 27, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7411), "Do you know what a CD No.27 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7413), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 27" },
                    { 31, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7616), "Do you know what a CD No.31 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7618), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 31" },
                    { 34, 4, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7782), "Do you know what a CD No.34 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(7783), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 34" },
                    { 41, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8130), "Do you know what a CD No.41 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8132), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 41" },
                    { 47, 3, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8431), "Do you know what a CD No.47 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8433), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 47" },
                    { 52, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8672), "Do you know what a CD No.52 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8673), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 52" },
                    { 53, 1, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8709), "Do you know what a CD No.53 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8711), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 53" },
                    { 55, 5, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8833), "Do you know what a CD No.55 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(8835), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 55" },
                    { 17, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6917), "Do you know what a CD No.17 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 34, DateTimeKind.Local).AddTicks(6919), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 2, "Deez nutz 17" },
                    { 197, 2, null, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5526), "Do you know what a CD No.197 is? Deez Nuts is the punchline of a conversational joke that involves asking someone a vaguely-phrased question to solicit a follow-up question in response, typically in the form of one of the five Ws, before yelling out the said phrase in an obnoxious manner. While originally introduced as a skit track on Dr. Dre's 1992 rap album Chronic, the joke saw a huge resurgence after it was featured in a short comedic sketch by Internet comedian WelvenDaGreat in early 2015.", "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", true, new DateTime(2022, 5, 10, 21, 35, 4, 35, DateTimeKind.Local).AddTicks(5528), 4.25, 0.68999999999999995, "Deez Nut haha, Gothem", 4, "Deez nutz 197" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
