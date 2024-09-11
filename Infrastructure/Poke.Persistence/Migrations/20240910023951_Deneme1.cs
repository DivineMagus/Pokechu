using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poke.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Deneme1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Details",
                newName: "Type");

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "Details",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "Details",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "PokeCenters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2024, 9, 10, 5, 39, 50, 531, DateTimeKind.Local).AddTicks(5850), "Sports, Music & Sports" });

            migrationBuilder.UpdateData(
                table: "PokeCenters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2024, 9, 10, 5, 39, 50, 531, DateTimeKind.Local).AddTicks(5867), "Jewelery, Clothing & Grocery" });

            migrationBuilder.UpdateData(
                table: "PokeCenters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2024, 9, 10, 5, 39, 50, 531, DateTimeKind.Local).AddTicks(5880), "Shoes & Toys" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 10, 5, 39, 50, 531, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 10, 5, 39, 50, 531, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 10, 5, 39, 50, 531, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 10, 5, 39, 50, 531, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Description", "Height", "Type", "Weight" },
                values: new object[] { new DateTime(2024, 9, 10, 5, 39, 50, 536, DateTimeKind.Local).AddTicks(424), "Nemo ipsa qui nemo lambadaki.", 0m, "Vel.", 0m });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Description", "Height", "Type", "Weight" },
                values: new object[] { new DateTime(2024, 9, 10, 5, 39, 50, 536, DateTimeKind.Local).AddTicks(1264), "Veniam cesurca architecto veniam sunt.", 0m, "Çorba cezbelendi.", 0m });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Description", "Height", "Type", "Weight" },
                values: new object[] { new DateTime(2024, 9, 10, 5, 39, 50, 536, DateTimeKind.Local).AddTicks(1305), "Ratione velit ipsam esse velit.", 0m, "İn ve odit.", 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 9, 10, 5, 39, 50, 540, DateTimeKind.Local).AddTicks(7778), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 7.727560755809580m, 212.39m, "Handcrafted Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 9, 10, 5, 39, 50, 540, DateTimeKind.Local).AddTicks(7811), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2.22634498411480m, 136.28m, "Handcrafted Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 9, 10, 5, 39, 50, 540, DateTimeKind.Local).AddTicks(7836), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 8.826223979732360m, 479.70m, "Handcrafted Concrete Bacon" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Details");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Details",
                newName: "Title");

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "PokeCenters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 57, 53, 227, DateTimeKind.Local).AddTicks(6550), "Automotive & Toys" });

            migrationBuilder.UpdateData(
                table: "PokeCenters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 57, 53, 227, DateTimeKind.Local).AddTicks(6563), "Tools & Grocery" });

            migrationBuilder.UpdateData(
                table: "PokeCenters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 57, 53, 227, DateTimeKind.Local).AddTicks(6581), "Games, Clothing & Garden" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 9, 15, 57, 53, 227, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 9, 15, 57, 53, 227, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 9, 15, 57, 53, 227, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 9, 15, 57, 53, 227, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 57, 53, 229, DateTimeKind.Local).AddTicks(9453), "İllo qui eve gülüyorum yazın.", "Adipisci." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 57, 53, 229, DateTimeKind.Local).AddTicks(9483), "Batarya aspernatur dergi quasi kalemi.", "Quia balıkhaneye." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 57, 53, 229, DateTimeKind.Local).AddTicks(9511), "Bahar commodi batarya layıkıyla için.", "Vel laboriosam ut." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 57, 53, 231, DateTimeKind.Local).AddTicks(9250), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 7.260179427675610m, 285.33m, "Intelligent Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 57, 53, 231, DateTimeKind.Local).AddTicks(9279), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1.703580337274120m, 837.43m, "Ergonomic Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 57, 53, 231, DateTimeKind.Local).AddTicks(9332), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4.690266704914470m, 600.22m, "Handmade Plastic Gloves" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}
