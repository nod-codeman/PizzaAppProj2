using Microsoft.EntityFrameworkCore.Migrations;

namespace VMANpizza.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qty",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Pizzas");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceL",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceM",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceS",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<double>(
                name: "QtyL",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "QtyM",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "QtyS",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceL",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "PriceM",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "PriceS",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "QtyL",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "QtyM",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "QtyS",
                table: "Pizzas");

            migrationBuilder.AddColumn<double>(
                name: "Qty",
                table: "Pizzas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
