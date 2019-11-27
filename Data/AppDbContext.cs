using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Models;
using VMANpizza.Models.ViewModel;

namespace VMANpizza.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>



        //options.UseSqlServer("data source =.\\nichmihai;Initial Catalog=VMANpizzaDb;Integrated Security=true;MultipleActiveResultSets=true;");

           //options.UseSqlServer("data source =.\\nichmihai;Initial Catalog=VMANpizzaDb;Integrated Security=true;MultipleActiveResultSets=true;");


        //options.UseSqlServer("data source =.\\SQLEXPRESS01;Initial Catalog=VMANpizzaDb;Integrated Security=true;MultipleActiveResultSets=true;");

        //options.UseSqlServer("data source =.\\nichmihai;Initial Catalog=VMANpizzaDb;Integrated Security=true;MultipleActiveResultSets=true;");


        options.UseSqlServer("data source =.\\SQLEXPRESS01;Initial Catalog=VMANpizzaDb;Integrated Security=true;MultipleActiveResultSets=true;");

        //options.UseSqlServer("Server=tcp:tserving.database.windows.net,1433;Initial Catalog=Vlive_prod;Persist Security Info=False;User ID=DBanger;Password=sdktesting@2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        public DbSet<Pizza> Pizzas { get; set; }
       
        public DbSet<VMANpizza.Models.ViewModel.OrderPizza> OrderPizza { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<VMANpizza.Models.ViewModel.LoginViewModel> LoginViewModel { get; set; }

    }
}

