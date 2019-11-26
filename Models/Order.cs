using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMANpizza.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public double totalPrice { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public Customer Customer { get; set; }
    }
}
