using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMANpizza.Models.ViewModel
{
    public class OrderPizza
    {
        public int Id { get; set; }
        public double QtySbac { get; set; }
        public double QtyMbac { get; set; }
        public double QtyLbac { get; set; }

        public double QtySsal { get; set; }
        public double QtyMsal { get; set; }
        public double QtyLsal { get; set; }

        public double QtySpep { get; set; }
        public double QtyMpep { get; set; }
        public double QtyLpep { get; set; }

        public double QtySmus { get; set; }
        public double QtyMmus { get; set; }
        public double QtyLmus { get; set; }

        public double QtySche { get; set; }
        public double QtyMche { get; set; }
        public double QtyLche { get; set; }

        public double QtySchk { get; set; }
        public double QtyMchk { get; set; }
        public double QtyLchk { get; set; }


        public int customerId { get; set; }
        public int orderId { get; set; }
    }
}
