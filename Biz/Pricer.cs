using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Data;
using VMANpizza.Models;

namespace VMANpizza.BL
{
    public class Pricer
    {
        public void TotalPrice(IFormCollection newOrder)
        {
            Pizza bacon = new Pizza();
            bacon.PizzaType = "Bacon";
            bacon.PriceS = 8;
            bacon.PriceM = 12;
            bacon.PriceL = 17;
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
            salami.PriceS = 11;
            salami.PriceM = 16;
            salami.PriceL = 19;
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
            pepperoni.PriceS = 7;
            pepperoni.PriceM = 11;
            pepperoni.PriceL = 14;
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
            mushroom.PriceS = 10;
            mushroom.PriceM = 14;
            mushroom.PriceL = 17;
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

            Pizza cheese = new Pizza();
            cheese.PizzaType = "Cheese";
            cheese.PriceS = 5;
            cheese.PriceM = 10;
            cheese.PriceL = 12;
            double csq;
            double.TryParse(newOrder["QtySche"], out csq);
            cheese.QtyS = csq;
            double cmq;
            double.TryParse(newOrder["QtyMche"], out cmq);
            cheese.QtyM = cmq;
            double clq;
            double.TryParse(newOrder["QtyLche"], out clq);
            cheese.QtyL = clq;

            Repository.Restore(cheese);

            Pizza chicken = new Pizza();
            chicken.PizzaType = "Chicken";
            chicken.PriceS = 10;
            chicken.PriceM = 14;
            chicken.PriceL = 18;
            double chsq;
            double.TryParse(newOrder["QtySchk"], out chsq);
            chicken.QtyS = chsq;
            double chmq;
            double.TryParse(newOrder["QtyMchk"], out chmq);
            chicken.QtyM = chmq;
            double chlq;
            double.TryParse(newOrder["QtyLchk"], out chlq);
            chicken.QtyL = chlq;

            Repository.Restore(chicken);

        }
    }
}
