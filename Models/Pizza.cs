using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VMANpizza.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Display(Name = "Pizza Type")]
        public string PizzaType { get; set; }
        //[Required]
        //public string Size { get; set; }
        public decimal PriceS { get; set; }
        public decimal PriceM { get; set; }
        public decimal PriceL { get; set; }
        public double QtyS { get; set; }
        public double QtyM { get; set; }
        public double QtyL { get; set; }
        public int OrderId { get; set; }
        public int CartId { get; set; }
    }
}
