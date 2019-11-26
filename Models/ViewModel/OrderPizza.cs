using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VMANpizza.Models.ViewModel
{
    public class OrderPizza
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

        public double QtySche { get; set; }
        public double QtyMche { get; set; }
        public double QtyLche { get; set; }

        public double QtySchk { get; set; }
        public double QtyMchk { get; set; }
        public double QtyLchk { get; set; }
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

        public double PriceSche { get; set; }
        public double PriceMche { get; set; }
        public double PriceLche { get; set; }

        public double PriceSchk { get; set; }
        public double PriceMchk { get; set; }
        public double PriceLchk { get; set; }
        #endregion

        #region All Pizza Types
        public string pizzaTypeBac { get; set; }
        public string pizzaTypeSal { get; set; }
        public string pizzaTypePep { get; set; }
        public string pizzaTypeMus { get; set; }
        public string pizzaTypeChe { get; set; }
        public string pizzaTypeChk { get; set; }
        #endregion
        public int customerId { get; set; }
        public string customerEmail { get; set; }
        public int orderId { get; set; }
        //public int cartId { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public double totalPrice { get; set; }
    }
}
