﻿using Microsoft.EntityFrameworkCore;
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
<<<<<<< HEAD

            options.UseSqlServer(@"data source=.\SQLEXPRESS;Initial Catalog=VmanPizzaDB;Integrated Security=true;MultipleActiveResultSets=True;");
            
        //options.UseSqlServer("Server=tcp:tserving.database.windows.net,1433;Initial Catalog = Vlive; Persist Security Info=False;User ID = DBanger; Password=sdktesting@2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");

=======

            options.UseSqlServer(@"data source=.\SQLEXPRESS;Initial Catalog=VmanPizzaDB;Integrated Security=true;MultipleActiveResultSets=True;");

          
        //options.UseSqlServer("Server=tcp:tserving.database.windows.net,1433;Initial Catalog=Vlive_prod;Persist Security Info=False;User ID=DBanger;Password=sdktesting@2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

>>>>>>> developerBranch

        public DbSet<Pizza> Pizzas { get; set; }
       
        public DbSet<VMANpizza.Models.ViewModel.OrderPizza> OrderPizza { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<VMANpizza.Models.ViewModel.LoginViewModel> LoginViewModel { get; set; }

    }
}

