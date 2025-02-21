using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM_DAL.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productBillDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BillInvoiceId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productBillDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productBillDetails_BillOfSales_BillInvoiceId",
                        column: x => x.BillInvoiceId,
                        principalTable: "BillOfSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productBillDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productPurchaseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PurchaseInvoiceId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productPurchaseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productPurchaseDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productPurchaseDetails_PurchaseInvoices_PurchaseInvoiceId",
                        column: x => x.PurchaseInvoiceId,
                        principalTable: "PurchaseInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_productBillDetails_BillInvoiceId",
                table: "productBillDetails",
                column: "BillInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_productBillDetails_ProductId",
                table: "productBillDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_productPurchaseDetails_ProductId",
                table: "productPurchaseDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_productPurchaseDetails_PurchaseInvoiceId",
                table: "productPurchaseDetails",
                column: "PurchaseInvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productBillDetails");

            migrationBuilder.DropTable(
                name: "productPurchaseDetails");
        }
    }
}
