using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodExpress.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class MojitoFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.easydrinks.sk/user/21497/upload/stuff/resized/21010959_1920-1920.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://cdn.myshoptet.com/usr/www.farmaufrantisky.cz/user/shop/big/2139_mojito.png?63c0024c");
        }
    }
}
