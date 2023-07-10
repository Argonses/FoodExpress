using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodExpress.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class DrinksAndFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Refreshing cola drink.", "https://d1ammsvb8n71kb.cloudfront.net/medias/sys_master/h21/hbc/8815442886686.jpg", "Coca-Cola", 1.99 },
                    { 2, "Freshly squeezed orange juice.", "https://www.marthastewart.com/thmb/v-noUz0Pm9dexdEBhiOKiC-TKhk=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/oj-upgrade-103121806_horiz_0-83474c4f9a0b4d7e9c06fc989fa1f5d2.jpgitokHQdK4qxB", "Orange Juice", 2.4900000000000002 },
                    { 3, "Chilled coffee with milk and ice.", "https://s7d1.scene7.com/is/image/mcdonalds/DC_201906_1212_MediumIcedCoffee_Glass_A1_832x472:1-3-product-tile-desktop?wid=765&hei=472&dpr=off", "Iced Coffee", 2.9900000000000002 },
                    { 4, "Refreshing lemon-flavored drink.", "https://1er.cz/3523-large_default/freshly-squeezed-lemonade-250ml.jpg", "Lemonade", 1.49 },
                    { 5, "Classic cocktail with rum, mint, lime, and soda.", "https://cdn.myshoptet.com/usr/www.farmaufrantisky.cz/user/shop/big/2139_mojito.png?63c0024c", "Mojito", 5.9900000000000002 },
                    { 6, "Chilled tea with a hint of lemon.", "https://www.chinamist.com/mm5/graphics/00000001/1/5300CM_TradBlack-LooseIced_24ct_730x616.jpg", "Iced Tea", 1.99 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 6, "French fries that you can have with different sauces.", "https://cdn.britannica.com/34/206334-050-7637EB66/French-fries.jpg", "French Fries", 2.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
