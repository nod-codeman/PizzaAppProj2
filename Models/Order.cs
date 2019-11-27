using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VMANpizza.Models
{
    public class Order
    {
        [Display(Name ="Order Id")]
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Total Pricce")]
        [DataType(DataType.Currency)]
        public double totalPrice { get; set; }
        //public int CartId { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public Customer Customer { get; set; }
    }
}
