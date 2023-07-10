using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodExpress.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Foods",
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
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Classic Neapolitan pizza with fresh mozzarella, tomatoes, and basil.", "https://www.rohlik.cz/cdn-cgi/image/f=auto,fit=cover,g=0.5x0.5,w=2900,h=1300/https://cdn.rohlik.cz/images/meals/large/237.jpg", "Pizza Margherita", 10.99 },
                    { 2, "Juicy beef patty with lettuce, tomato, onion, and pickles on a sesame seed bun.", "https://www.sousviderecepty.cz/wp-content/uploads/2020/11/sousvide-hamburger.png", "Hamburger", 9.9900000000000002 },
                    { 3, "Crisp romaine lettuce with Parmesan cheese, croutons, and creamy Caesar dressing.", "https://media.istockphoto.com/id/688372776/photo/caesar-salad-on-white-background.jpg?s=612x612&w=0&k=20&c=kwaTRLVv5ANGZEhf86QH9t6_dYI_RVHfZ35dtFDECes=", "Caesar Salad", 8.9900000000000002 },
                    { 4, "Fresh sushi roll with a variety of fish, vegetables, and sticky rice.", "https://img.freepik.com/premium-photo/group-rolls-maki-isolated-white-background_185193-73954.jpg?w=2000", "Sushi Roll", 7.9900000000000002 },
                    { 5, "Sautéed chicken with mixed vegetables and soy sauce served over steamed rice.", "https://img.freepik.com/premium-photo/stir-fry-chicken-with-vegetables-plate-isolated-white-background_123827-16364.jpg", "Chicken Stir-Fry", 6.9900000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
