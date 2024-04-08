using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    public partial class AddSeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "DatePublished", "Description", "ImageUrl", "Language", "Price", "Title" },
                values: new object[] { "Dale Carnegie", new DateTime(1936, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "xoay quanh những vấn đề xây dựng, cải thiện, phát triển mối quan hệ, cách ứng xử giữa người với người.", "/images/dacnhantam.jpg", "Tiếng Việt", 99, "Đắc nhân tâm" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DatePublished", "Description", "ImageUrl", "Language", "Price", "Title" },
                values: new object[] { 7, "Astrid Lindgren", new DateTime(2013, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "/images/lejonhjärta.jpg", "Swedish", 139, "Bröderna Lejonhjärta" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DatePublished", "Description", "ImageUrl", "Language", "Price", "Title" },
                values: new object[] { 8, "Paulo Coelho", new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "là tiểu thuyết được xuất bản lần đầu ở Brasil năm 1988,đã được dịch ra 67 ngôn ngữ và bán tới 95 triệu bản", "\\images\\nhagiakim.jpg", "Tiếng Việt", 129, "Nhà giả kim" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "DatePublished", "Description", "ImageUrl", "Language", "Price", "Title" },
                values: new object[] { "Astrid Lindgren", new DateTime(2013, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "/images/lejonhjärta.jpg", "Swedish", 139, "Bröderna Lejonhjärta" });
        }
    }
}
