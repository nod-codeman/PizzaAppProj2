using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Models;

namespace VMANpizza.Data
{
    public class Repository:Controller
    {
        
        public static List<Pizza> AllOrders { get; set; }

        private static AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;

            
        }

        public static List<Order> Orders()
        {
            var Orders = _context.Orders.ToList();

            return Orders;
        
        }
        public static void Start()
        {

            AllOrders = new List<Pizza>()
            {
                new Pizza { Id = 0}
            };

        }
        public static IEnumerable<Pizza> GetPizzas()
        {
            var PizzaList = AllOrders.TakeLast(6);

            return PizzaList;
        }

        public static void Restore(Pizza order)
        {


            AllOrders.Add(order);

        }
    }
}

/* After we implement CustomerId to Pizza Table
        public static List<Pizza> GetCustomerOrders(int customerid)
        {
            List<Pizza> customerorders = (from orders in AllOrders
                                         where orders.CustomerId == customerid
                                         select orders).ToList();


            return customerorders;

        }
    }
}
}
*/
