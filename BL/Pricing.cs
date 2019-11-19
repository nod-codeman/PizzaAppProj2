﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Data;
using VMANpizza.Models;

namespace VMANpizza.BL
{
    public class Pricing
    {
        public void TotalPrice(IFormCollection newOrder)
        {
            Pizza bacon = new Pizza();
            bacon.PizzaType = "Bacon";
            bacon.PriceS = 2;
            bacon.PriceM = 5;
            bacon.PriceL = 7;
            double bsq;
            double.TryParse(newOrder["QtySbac"], out bsq);
            bacon.QtyS = bsq;
            double bmq;
            double.TryParse(newOrder["QtyMbac"], out bmq);
            bacon.QtyM = bmq;
            double blq;
            double.TryParse(newOrder["QtyLbac"], out blq);
            bacon.QtyL = blq;

            Repository.Restore(bacon);

            Pizza salami = new Pizza();
            salami.PizzaType = "Salami";
            salami.PriceS = 3;
            salami.PriceM = 6;
            salami.PriceL = 8;
            double ssq;
            double.TryParse(newOrder["QtySsal"], out ssq);
            salami.QtyS = ssq;
            double smq;
            double.TryParse(newOrder["QtyMsal"], out smq);
            salami.QtyM = smq;
            double slq;
            double.TryParse(newOrder["QtyLsal"], out slq);
            salami.QtyL = slq;

            Repository.Restore(salami);

            Pizza pepperoni = new Pizza();
            pepperoni.PizzaType = "Pepperoni";
            pepperoni.PriceS = 3;
            pepperoni.PriceM = 6;
            pepperoni.PriceL = 8;
            double psq;
            double.TryParse(newOrder["QtySpep"], out psq);
            pepperoni.QtyS = psq;
            double pmq;
            double.TryParse(newOrder["QtyMpep"], out pmq);
            pepperoni.QtyM = pmq;
            double plq;
            double.TryParse(newOrder["QtyLpep"], out plq);
            pepperoni.QtyL = plq;

            Repository.Restore(pepperoni);

            Pizza mushroom = new Pizza();
            mushroom.PizzaType = "Mushroom";
            mushroom.PriceS = 3;
            mushroom.PriceM = 6;
            mushroom.PriceL = 8;
            double msq;
            double.TryParse(newOrder["QtySmus"], out msq);
            mushroom.QtyS = msq;
            double mmq;
            double.TryParse(newOrder["QtyMmus"], out mmq);
            mushroom.QtyM = mmq;
            double mlq;
            double.TryParse(newOrder["QtyLmus"], out mlq);
            mushroom.QtyL = mlq;

            Repository.Restore(mushroom);

        }
    }
}
