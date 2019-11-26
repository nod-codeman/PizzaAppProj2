using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VMANpizza.Migrations
{
    public partial class AddingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoginViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginViewModel", x => x.Id);
                });

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
                    OrderDate = table.Column<DateTime>(nullable: false),
                    totalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPizza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    totalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaType = table.Column<string>(nullable: true),
                    QtyS = table.Column<double>(nullable: false),
                    QtyM = table.Column<double>(nullable: false),
                    QtyL = table.Column<double>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pizzas_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderId",
                table: "Pizzas",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "LoginViewModel");

            migrationBuilder.DropTable(
                name: "OrderPizza");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
