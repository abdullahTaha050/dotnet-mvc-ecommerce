using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecommerce_mvc_tutorial.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHomePage",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "IsHomePage" },
                values: new object[] { "Lorem ipsum, dolor sit amet consectetur qor voluptatem explnissimos! Deleniti.", "1.jpeg", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "IsHomePage" },
                values: new object[] { "Lorem ipsum, dolor sit amet consectetur qor voluptatem explnissimos! Deleniti.", "2.jpeg", false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "IsHomePage" },
                values: new object[] { "Lorem ipsum, dolor sit amet consectetur qor voluptatem explnissimos! Deleniti.", "3.jpeg", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsHomePage",
                table: "Products");
        }
    }
}
