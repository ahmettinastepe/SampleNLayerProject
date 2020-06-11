using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleNLayerProject.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dosyaNo = table.Column<int>(nullable: false),
                    hastaTCKimlikNo = table.Column<int>(nullable: false),
                    hastaAdi = table.Column<string>(maxLength: 50, nullable: false),
                    hastaSoyadi = table.Column<string>(maxLength: 50, nullable: false),
                    orderTarihSaat = table.Column<DateTime>(nullable: false),
                    hastaTipi = table.Column<int>(nullable: false),
                    artirimOrani = table.Column<int>(nullable: false),
                    klinikAdi = table.Column<string>(nullable: false),
                    orderVerenDoktorAdSoyad = table.Column<string>(maxLength: 100, nullable: false),
                    dogumTarihi = table.Column<DateTime>(nullable: false),
                    kilo = table.Column<double>(nullable: false),
                    cinsiyet = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    InnerBarcode = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Solusyon",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderId = table.Column<int>(nullable: false),
                    volume = table.Column<double>(nullable: false),
                    doktorMiktar = table.Column<int>(nullable: false),
                    solusyonTipId = table.Column<int>(nullable: false),
                    solusyonId = table.Column<int>(nullable: false),
                    birim = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solusyon", x => x.id);
                    table.ForeignKey(
                        name: "FK_Solusyon_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { 1, false, "Kalemler" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { 2, false, "Defterler" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "InnerBarcode", "IsDeleted", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, null, false, "Pilot Kalem", 8.25m, 20 },
                    { 2, 1, null, false, "Tükenmez Kalem", 9m, 90 },
                    { 3, 1, null, false, "Kurşun Kalem", 1m, 200 },
                    { 4, 2, null, false, "Kareli Defter", 2.50m, 150 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Solusyon_orderId",
                table: "Solusyon",
                column: "orderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Solusyon");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
