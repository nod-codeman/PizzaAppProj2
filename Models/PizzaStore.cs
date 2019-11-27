using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMANpizza.Models
{
    public class PizzaStore
    {
        public int Id { get; set; }
        public string PizzaType { get; set; }
        public double PriceS { get; set; }
        public double PriceM { get; set; }
        public double PriceL { get; set; }

    }
}
