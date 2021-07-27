using Microsoft.EntityFrameworkCore.Migrations;

namespace EStore.DataAccess.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 9, "Lenovo" },
                    { 8, "HP" },
                    { 7, "Siemens" },
                    { 6, "Bosch" },
                    { 10, "Huawei" },
                    { 4, "Xiaomi" },
                    { 3, "LG" },
                    { 2, "Apple" },
                    { 5, "Dell" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Моноблоки" },
                    { 1, "Телефоны" },
                    { 2, "Телевизоры" },
                    { 3, "Холодильники" },
                    { 4, "Ноутбуки" },
                    { 5, "Принтеры" },
                    { 6, "Пылесосы" },
                    { 7, "Сушильные машины" },
                    { 8, "Электрочайники" },
                    { 10, "Мониторы" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "ImagePath", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { 1, 2, 1, "", "Iphone 12", 103390m, 5 },
                    { 8, 8, 9, "", "Моноблок HP 22-df0025ur 14P64EA", 42990m, 5 },
                    { 7, 9, 9, "", "Моноблок для бизнеса Lenovo V30a-24IML", 57790m, 6 },
                    { 12, 4, 8, "", "Электрочайник Xiaomi Mi Smart Kettle YM-K1501", 32990m, 1 },
                    { 11, 6, 8, "", "Электрочайник Bosch TWK7S05", 8990m, 4 },
                    { 18, 1, 7, "", "Сушильная машина Samsung DV90TA040AE", 43390m, 6 },
                    { 17, 3, 7, "", "Сушильная машина LG DC90V9V9W", 59390m, 8 },
                    { 14, 4, 6, "", "Робот-пылесос Xiaomi Robot Vacuum-Mop", 15390m, 2 },
                    { 13, 1, 6, "", "Пылесос ручной (handstick) Samsung Jet 70 turbo", 19990m, 3 },
                    { 16, 1, 5, "", "Лазерный принтер Samsung Xpress M2020", 93390m, 10 },
                    { 15, 8, 5, "", "Лазерный принтер HP Laser 107wr", 8690m, 9 },
                    { 6, 9, 4, "", "Ноутбук игровой Lenovo Legion 5 15ACH6H", 109900m, 5 },
                    { 5, 10, 4, "", "Ноутбук Huawei MateBook D15 BoB-WAI9", 47490m, 2 },
                    { 20, 6, 3, "", "Холодильник Bosch Serie", 45990m, 2 },
                    { 19, 3, 3, "", "Холодильник LG DoorCoolingи", 39390m, 3 },
                    { 10, 1, 2, "", "Телевизор Samsung QE50Q67TAU", 52990m, 5 },
                    { 9, 3, 2, "", "Телевизор LG NanoCell 55NANO866NA", 57790m, 5 },
                    { 2, 4, 1, "", "Xiaomi Mi 11 Lite 4G", 30900m, 7 },
                    { 3, 8, 10, "", "Монитор игровой HP X24c", 13490m, 9 },
                    { 4, 1, 10, "", "Монитор Samsung S24F354FHI", 9490m, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");
        }
    }
}
