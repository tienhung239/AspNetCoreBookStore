using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DatePublished", "Description", "ImageUrl", "Language", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Astrid Lindgren", new DateTime(2013, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "/images/lejonhjärta.jpg", "Swedish", 139, "Bröderna Lejonhjärta" },
                    { 2, "J. R. R. Tolkien", new DateTime(1991, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "/images/lotr.jpg", "English", 100, "The Fellowship of the Ring" },
                    { 3, "Dennis Lehane", new DateTime(2011, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "/images/mystic-river.jpg", "English", 91, "Mystic River" },
                    { 4, "John Steinbeck", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "/images/of-mice-and-men.jpg", "English", 166, "Of Mice and Men" },
                    { 5, "Ernest Hemingway", new DateTime(1994, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "/images/old-man-and-the-sea.jpg", "English", 84, "The Old Man and the Sea" },
                    { 6, "Cormac McCarthy", new DateTime(2007, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "/images/the-road.jpg", "English", 95, "The Road" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_BookId",
                table: "CartItems",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
