using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VMANpizza.Migrations
{
    public partial class Inits1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "OrderPizza",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QtySbac = table.Column<double>(nullable: false),
                    QtyMbac = table.Column<double>(nullable: false),
                    QtyLbac = table.Column<double>(nullable: false),
                    QtySsal = table.Column<double>(nullable: false),
                    QtyMsal = table.Column<double>(nullable: false),
                    QtyLsal = table.Column<double>(nullable: false),
                    QtySpep = table.Column<double>(nullable: false),
                    QtyMpep = table.Column<double>(nullable: false),
                    QtyLpep = table.Column<double>(nullable: false),
                    QtySmus = table.Column<double>(nullable: false),
                    QtyMmus = table.Column<double>(nullable: false),
                    QtyLmus = table.Column<double>(nullable: false),
                    QtySche = table.Column<double>(nullable: false),
                    QtyMche = table.Column<double>(nullable: false),
                    QtyLche = table.Column<double>(nullable: false),
                    QtySchk = table.Column<double>(nullable: false),
                    QtyMchk = table.Column<double>(nullable: false),
                    QtyLchk = table.Column<double>(nullable: false),
                    customerId = table.Column<int>(nullable: false),
                    orderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPizza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderPizzaCustomer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QtySbac = table.Column<double>(nullable: false),
                    QtyMbac = table.Column<double>(nullable: false),
                    QtyLbac = table.Column<double>(nullable: false),
                    QtySsal = table.Column<double>(nullable: false),
                    QtyMsal = table.Column<double>(nullable: false),
                    QtyLsal = table.Column<double>(nullable: false),
                    QtySpep = table.Column<double>(nullable: false),
                    QtyMpep = table.Column<double>(nullable: false),
                    QtyLpep = table.Column<double>(nullable: false),
                    QtySmus = table.Column<double>(nullable: false),
                    QtyMmus = table.Column<double>(nullable: false),
                    QtyLmus = table.Column<double>(nullable: false),
                    QtySche = table.Column<double>(nullable: false),
                    QtyMche = table.Column<double>(nullable: false),
                    QtyLche = table.Column<double>(nullable: false),
                    QtySchk = table.Column<double>(nullable: false),
                    QtyMchk = table.Column<double>(nullable: false),
                    QtyLchk = table.Column<double>(nullable: false),
                    PriceSbac = table.Column<double>(nullable: false),
                    PriceMbac = table.Column<double>(nullable: false),
                    PriceLbac = table.Column<double>(nullable: false),
                    PriceSsal = table.Column<double>(nullable: false),
                    PriceMsal = table.Column<double>(nullable: false),
                    PriceLsal = table.Column<double>(nullable: false),
                    PriceSpep = table.Column<double>(nullable: false),
                    PriceMpep = table.Column<double>(nullable: false),
                    PriceLpep = table.Column<double>(nullable: false),
                    PriceSmus = table.Column<double>(nullable: false),
                    PriceMmus = table.Column<double>(nullable: false),
                    PriceLmus = table.Column<double>(nullable: false),
                    PriceSche = table.Column<double>(nullable: false),
                    PriceMche = table.Column<double>(nullable: false),
                    PriceLche = table.Column<double>(nullable: false),
                    PriceSchk = table.Column<double>(nullable: false),
                    PriceMchk = table.Column<double>(nullable: false),
                    PriceLchk = table.Column<double>(nullable: false),
                    pizzaTypeBac = table.Column<string>(nullable: true),
                    pizzaTypeSal = table.Column<string>(nullable: true),
                    pizzaTypePep = table.Column<string>(nullable: true),
                    pizzaTypeMus = table.Column<string>(nullable: true),
                    pizzaTypeChe = table.Column<string>(nullable: true),
                    pizzaTypeChk = table.Column<string>(nullable: true),
                    customerId = table.Column<int>(nullable: false),
                    orderId = table.Column<int>(nullable: false),
                    cartId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    totalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPizzaCustomer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderPizza");

            migrationBuilder.DropTable(
                name: "OrderPizzaCustomer");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceL",
                table: "Pizzas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceM",
                table: "Pizzas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceS",
                table: "Pizzas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
