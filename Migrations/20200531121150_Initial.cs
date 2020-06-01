using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheBookStore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    PageCount = table.Column<int>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
