using Microsoft.AspNetCore.Http;
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
