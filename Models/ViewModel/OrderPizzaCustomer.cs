using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMANpizza.Models.ViewModel
{
    public class OrderPizzaCustomer
    {
        public int Id { get; set; }

        #region All quatity
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
        #endregion

        #region All prices
        public double PriceSbac { get; set; }
        public double PriceMbac { get; set; }
        public double PriceLbac { get; set; }

        public double PriceSsal { get; set; }
        public double PriceMsal { get; set; }
        public double PriceLsal { get; set; }

        public double PriceSpep { get; set; }
        public double PriceMpep { get; set; }
        public double PriceLpep { get; set; }

        public double PriceSmus { get; set; }
        public double PriceMmus { get; set; }
        public double PriceLmus { get; set; }
        #endregion

        #region All Pizza Types
        public int pizzaTypeBac { get; set; }
        public int pizzaTypeSal { get; set; }
        public int pizzaTypePep { get; set; }
        public int pizzaTypeMus { get; set; }
        #endregion
        public int customerId { get; set; }
        public int orderId { get; set; }
        public int cartId { get; set; }
        public DateTime OrderDate { get; set; }
        public double totalPrice { get; set; }
    }
}
