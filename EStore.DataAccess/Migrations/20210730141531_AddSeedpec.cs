using Microsoft.EntityFrameworkCore.Migrations;

namespace EStore.DataAccess.Migrations
{
    public partial class AddSeedpec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificationType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpecifications",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SpecificationId = table.Column<int>(type: "int", nullable: false),
                    SpecString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecDecimal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SpecBoolean = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecifications", x => new { x.ProductId, x.SpecificationId });
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_Specifications_SpecificationId",
                        column: x => x.SpecificationId,
                        principalTable: "Specifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Specifications",
                columns: new[] { "Id", "Name", "SpecificationType" },
                values: new object[,]
                {
                    { 1, "Цвет", 1 },
                    { 2, "Вес", 2 },
                    { 3, "Подсветка", 3 },
                    { 4, "Диагональ экрана", 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecifications",
                columns: new[] { "ProductId", "SpecificationId", "SpecBoolean", "SpecDecimal", "SpecString" },
                values: new object[,]
                {
                    { 1, 1, null, null, "Красный" },
                    { 15, 2, null, 3m, null },
                    { 16, 2, null, 3m, null },
                    { 17, 2, null, 15m, null },
                    { 18, 2, null, 25m, null },
                    { 19, 2, null, 25m, null },
                    { 20, 2, null, 30m, null },
                    { 1, 3, true, null, null },
                    { 2, 3, true, null, null },
                    { 3, 3, true, null, null },
                    { 4, 3, true, null, null },
                    { 5, 3, true, null, null },
                    { 6, 3, true, null, null },
                    { 7, 3, false, null, null },
                    { 14, 2, null, 3m, null },
                    { 8, 3, true, null, null },
                    { 10, 3, true, null, null },
                    { 12, 3, true, null, null },
                    { 18, 3, true, null, null },
                    { 19, 3, true, null, null },
                    { 1, 4, null, 5m, null },
                    { 2, 4, null, 5m, null },
                    { 3, 4, null, 21m, null },
                    { 4, 4, null, 19m, null },
                    { 5, 4, null, 13m, null },
                    { 6, 4, null, 15m, null },
                    { 7, 4, null, 62m, null },
                    { 8, 4, null, 34m, null },
                    { 9, 4, null, 55m, null },
                    { 9, 3, false, null, null },
                    { 13, 2, null, 2m, null },
                    { 12, 2, null, 0.3m, null },
                    { 11, 2, null, 0.5m, null },
                    { 2, 1, null, null, "Синий" },
                    { 3, 1, null, null, "Синий" },
                    { 4, 1, null, null, "Белый" },
                    { 5, 1, null, null, "Черный" },
                    { 6, 1, null, null, "Синий" },
                    { 7, 1, null, null, "Черный" },
                    { 8, 1, null, null, "Белый" },
                    { 9, 1, null, null, "Черный" },
                    { 10, 1, null, null, "Красный" }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecifications",
                columns: new[] { "ProductId", "SpecificationId", "SpecBoolean", "SpecDecimal", "SpecString" },
                values: new object[,]
                {
                    { 11, 1, null, null, "Красный" },
                    { 12, 1, null, null, "Красный" },
                    { 13, 1, null, null, "Белый" },
                    { 14, 1, null, null, "Белый" },
                    { 15, 1, null, null, "Синий" },
                    { 16, 1, null, null, "Черный" },
                    { 17, 1, null, null, "Черный" },
                    { 18, 1, null, null, "Белый" },
                    { 19, 1, null, null, "Белый" },
                    { 20, 1, null, null, "Красный" },
                    { 1, 2, null, 0.18m, null },
                    { 2, 2, null, 0.5m, null },
                    { 3, 2, null, 1m, null },
                    { 4, 2, null, 1.5m, null },
                    { 5, 2, null, 1.5m, null },
                    { 6, 2, null, 1.5m, null },
                    { 7, 2, null, 3.5m, null },
                    { 8, 2, null, 2.6m, null },
                    { 9, 2, null, 2.5m, null },
                    { 10, 2, null, 2m, null },
                    { 10, 4, null, 43m, null },
                    { 19, 4, null, 19m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_SpecificationId",
                table: "ProductSpecifications",
                column: "SpecificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSpecifications");

            migrationBuilder.DropTable(
                name: "Specifications");
        }
    }
}
