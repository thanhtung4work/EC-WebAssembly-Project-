using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Suchimu.Server.Migrations
{
    public partial class MoreGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 869, DateTimeKind.Local).AddTicks(8739), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5798), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5815), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5825), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5842), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5846), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5854), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5864), new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5868), "https://upload.wikimedia.org/wikipedia/en/5/57/Doom_cover_art.jpg", new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5873), "https://upload.wikimedia.org/wikipedia/vi/2/29/Doom_II_-_Hell_on_Earth_Coverart.png", new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5879), "https://upload.wikimedia.org/wikipedia/en/2/28/Doom_Cover.jpg", new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5883), "https://i1.sndcdn.com/artworks-LwIUm8NfefhxgNrz-WlctLg-t500x500.jpg", new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5887), "https://upload.wikimedia.org/wikipedia/vi/5/57/Half-life-cover.jpg", new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5891), "https://upload.wikimedia.org/wikipedia/vi/2/25/Half-Life_2_cover.jpg", new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Description", "ImageUrl", "IsActive", "LatestUpdate", "OriginalPrice", "Price", "ShortDescription", "StudioId", "Title" },
                values: new object[,]
                {
                    { 22, 2, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5918), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.", "https://assets-prd.ignimgs.com/2020/11/05/yakuza-zero-button-fin-1604543502548.jpg", true, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5919), 450000.0, 220000.0, "Deez Nut haha, Gothem", 3, "Yakuza 0" },
                    { 26, 2, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5934), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Sonic_Mania_%28artwork%29.jpg", true, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5936), 650000.0, 420000.0, "Deez Nut haha, Gothem", 3, "Sonic Mania" },
                    { 25, 2, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5930), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.", "https://upload.wikimedia.org/wikipedia/en/9/99/Sonic_Adventure_2_cover.png", true, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5932), 650000.0, 420000.0, "Deez Nut haha, Gothem", 3, "Sonic Adventure 2" },
                    { 24, 2, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5926), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.", "https://upload.wikimedia.org/wikipedia/en/6/60/Sonic_Adventure.PNG", true, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5928), 650000.0, 420000.0, "Deez Nut haha, Gothem", 3, "Sonic Adventure" },
                    { 23, 2, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5922), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.", "https://assets-prd.ignimgs.com/2020/11/05/yakuza-zero-button-fin-1604543502548.jpg", true, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5924), 650000.0, 420000.0, "Deez Nut haha, Gothem", 3, "Yakuza: Like a dragon" }
                });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://logowik.com/content/uploads/images/nintendo4059.jpg");

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "Email", "ImageUrl", "Location", "Name", "Url" },
                values: new object[] { 8, "contact@ubisoft.com", "https://upload.wikimedia.org/wikipedia/commons/6/6c/New_Ubisoft_Logo.jpg", "USA", "Ubisoft", "studio_ubisoft" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Description", "ImageUrl", "IsActive", "LatestUpdate", "OriginalPrice", "Price", "ShortDescription", "StudioId", "Title" },
                values: new object[,]
                {
                    { 18, 1, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5897), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Far_Cry_1_boxshot.jpg", true, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5899), 45000.0, 20000.0, "Deez Nut haha, Gothem", 8, "Far cry 1" },
                    { 19, 1, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5901), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.", "https://upload.wikimedia.org/wikipedia/en/9/97/Far_Cry_2_cover_art.jpg", true, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5903), 45000.0, 20000.0, "Deez Nut haha, Gothem", 8, "Far cry 2" },
                    { 20, 1, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5905), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.", "https://upload.wikimedia.org/wikipedia/vi/7/71/Far_Cry_3_dvd_cover.jpg", true, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5907), 85000.0, 40000.0, "Deez Nut haha, Gothem", 8, "Far cry 3" },
                    { 21, 1, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5909), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.", "https://upload.wikimedia.org/wikipedia/vi/1/12/Far_Cry_4_cover.jpg", true, new DateTime(2022, 5, 15, 9, 50, 12, 871, DateTimeKind.Local).AddTicks(5911), 450000.0, 220000.0, "Deez Nut haha, Gothem", 8, "Far cry 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Studios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 855, DateTimeKind.Local).AddTicks(7415), new DateTime(2022, 5, 14, 23, 11, 38, 856, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5039), new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5056), new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5061), new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5065), new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5073), new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5077), new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5081), new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5085), new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5090), new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5094), new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5099), "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5103), "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5107), "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5111), "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5116), "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ImageUrl", "LatestUpdate" },
                values: new object[] { new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5199), "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd", new DateTime(2022, 5, 14, 23, 11, 38, 857, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://slotcatalog.com/userfiles/image/brand/Konami_m.jpg");
        }
    }
}
