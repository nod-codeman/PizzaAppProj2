using Microsoft.EntityFrameworkCore.Migrations;

namespace VMANpizza.Migrations
{
    public partial class CreatedCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
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
                    customerId = table.Column<int>(nullable: false),
                    orderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPizza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaType = table.Column<string>(nullable: true),
                    PriceS = table.Column<decimal>(nullable: false),
                    PriceM = table.Column<decimal>(nullable: false),
                    PriceL = table.Column<decimal>(nullable: false),
                    QtyS = table.Column<double>(nullable: false),
                    QtyM = table.Column<double>(nullable: false),
                    QtyL = table.Column<double>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    CartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderPizza");

            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
