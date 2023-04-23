using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCartListApi.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shoppingCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<double>(type: "REAL", nullable: false),
                    isPickedUp = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingCart", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "shoppingCart",
                columns: new[] { "Id", "ItemName", "Quantity", "isPickedUp" },
                values: new object[,]
                {
                    { 1, "Banana", 3.0, false },
                    { 2, "Orange", 5.0, false },
                    { 3, "Apple", 2.0, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shoppingCart");
        }
    }
}
