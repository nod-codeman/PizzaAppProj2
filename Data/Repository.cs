using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Models;

namespace VMANpizza.Data
{
    public class Repository
    {
        public static List<Pizza> AllOrders { get; set; }

        public static void Start()
        {

            AllOrders = new List<Pizza>()
            {
                new Pizza { Id = 0}
            };

        }
        public static IEnumerable<Pizza> GetPizzas()
        {
            var PizzaList = AllOrders.TakeLast(4);

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
