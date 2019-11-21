using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMANpizza.Models;
using VMANpizza.Models.ViewModel;

namespace VMANpizza.Controllers
{
    public class OrderPizzaCustomers1Controller : Controller
    {
        private readonly AppDbContext _context;

        public OrderPizzaCustomers1Controller(AppDbContext context)
        {
            _context = context;
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,QtySche,QtyMche,QtyLche,QtySchk,QtyMchk,QtyLchk,PriceSbac,PriceMbac,PriceLbac,PriceSsal,PriceMsal,PriceLsal,PriceSpep,PriceMpep,PriceLpep,PriceSmus,PriceMmus,PriceLmus,PriceSche,PriceMche,PriceLche,PriceSchk,PriceMchk,PriceLchk,pizzaTypeBac,pizzaTypeSal,pizzaTypePep,pizzaTypeMus,pizzaTypeChe,pizzaTypeChk,customerId,orderId,OrderDate,totalPrice")] OrderPizzaCustomer orderPizzaCustomer)
        {
            orderPizzaCustomer.pizzaTypeBac = "Bacon";
            orderPizzaCustomer.pizzaTypePep = "Pepperoni";
            orderPizzaCustomer.pizzaTypeSal = "Salami";
            orderPizzaCustomer.pizzaTypeChe = "Cheese";
            orderPizzaCustomer.pizzaTypeChk = "Chicken";
            orderPizzaCustomer.pizzaTypeMus = "Mushroom";

            var CustId = await _context.Customers.ToListAsync();
            int currCustId;
            if (CustId.Count != 0)
            {
                currCustId = CustId.Max(o => o.Id);
            }
            else
            { currCustId = 1; }
            orderPizzaCustomer.customerId = currCustId;

            var OrderId = await _context.Orders.ToListAsync();
            int currOrderId;
            if (OrderId.Count != 0)
            {
                currOrderId = OrderId.Max(o => o.Id)+1;
            }
            else
            { currOrderId = 1; }
            if (ModelState.IsValid)
            {
                Order order = new Order()
                {
                    totalPrice = orderPizzaCustomer.totalPrice,
                    OrderDate = orderPizzaCustomer.OrderDate,
                    CustomerId = currCustId
                };
                _context.Add(order);
                if (orderPizzaCustomer.QtySbac != 0 || orderPizzaCustomer.QtyMbac != 0 || orderPizzaCustomer.QtyLbac != 0)
                {
                    Pizza bacPizza = new Pizza()
                    {
                        PizzaType = orderPizzaCustomer.pizzaTypeBac,
                        QtyS = orderPizzaCustomer.QtySbac,
                        QtyM = orderPizzaCustomer.QtyMbac,
                        QtyL = orderPizzaCustomer.QtyLbac,
                        OrderId = currOrderId
                    };
                    _context.Add(bacPizza);
                    //await _context.SaveChangesAsync();
                }
                if (orderPizzaCustomer.QtySsal != 0 || orderPizzaCustomer.QtyMsal != 0 || orderPizzaCustomer.QtyLsal != 0)
                {
                    Pizza salPizza = new Pizza()
                    {
                        PizzaType = orderPizzaCustomer.pizzaTypeSal,
                        QtyS = orderPizzaCustomer.QtySsal,
                        QtyM = orderPizzaCustomer.QtyMsal,
                        QtyL = orderPizzaCustomer.QtyLsal,
                        OrderId = currOrderId
                    };
                    _context.Add(salPizza);
                    //await _context.SaveChangesAsync();
                }
                if (orderPizzaCustomer.QtySpep != 0 || orderPizzaCustomer.QtyMpep != 0 || orderPizzaCustomer.QtyLpep != 0)
                {
                    Pizza pepPizza = new Pizza()
                    {
                        PizzaType = orderPizzaCustomer.pizzaTypePep,
                        QtyS = orderPizzaCustomer.QtySpep,
                        QtyM = orderPizzaCustomer.QtyMpep,
                        QtyL = orderPizzaCustomer.QtyLpep,
                        OrderId = currOrderId
                    };
                    _context.Add(pepPizza);
                    //await _context.SaveChangesAsync();
                }
                if (orderPizzaCustomer.QtySmus != 0 || orderPizzaCustomer.QtyMmus != 0 || orderPizzaCustomer.QtyLmus != 0)
                {
                    Pizza musPizza = new Pizza()
                    {
                        PizzaType = orderPizzaCustomer.pizzaTypeMus,
                        QtyS = orderPizzaCustomer.QtySmus,
                        QtyM = orderPizzaCustomer.QtyMmus,
                        QtyL = orderPizzaCustomer.QtyLmus,
                        OrderId = currOrderId
                    };
                    _context.Add(musPizza);
                    //await _context.SaveChangesAsync();
                }
                if (orderPizzaCustomer.QtySche != 0 || orderPizzaCustomer.QtyMche != 0 || orderPizzaCustomer.QtyLche != 0)
                {
                    Pizza chePizza = new Pizza()
                    {
                        PizzaType = orderPizzaCustomer.pizzaTypeChe,
                        QtyS = orderPizzaCustomer.QtySche,
                        QtyM = orderPizzaCustomer.QtyMche,
                        QtyL = orderPizzaCustomer.QtyLche,
                        OrderId = currOrderId
                    };
                    _context.Add(chePizza);
                    //await _context.SaveChangesAsync();
                }
                if (orderPizzaCustomer.QtySchk != 0 || orderPizzaCustomer.QtyMchk != 0 || orderPizzaCustomer.QtyLchk != 0)
                {
                    Pizza chkPizza = new Pizza()
                    {
                        PizzaType = orderPizzaCustomer.pizzaTypeBac,
                        QtyS = orderPizzaCustomer.QtySchk,
                        QtyM = orderPizzaCustomer.QtyMchk,
                        QtyL = orderPizzaCustomer.QtyLchk,
                        OrderId = currOrderId
                    };
                    _context.Add(chkPizza);
                    //await _context.SaveChangesAsync();
                }
                
                await _context.SaveChangesAsync();
                return View("Views/Home/Index.cshtml");
            }
            return View("Views/Home/Index.cshtml");
        }

        // GET: OrderPizzaCustomers1/CreateOrderPizza
        public IActionResult CreateOrderPizza()
        {
            OrderPizzaCustomer OrderPizzasList = new OrderPizzaCustomer
            {
                pizzaTypeBac = "Bacon",
                PriceSbac = 2,
                PriceMbac = 5,
                PriceLbac = 7,
                //QtyS = orderPizza.QtySbac,
                //QtyM = orderPizza.QtyMbac,
                //QtyL = orderPizza.QtyLbac,

                pizzaTypeSal = "Salami",
                PriceSsal = 3,
                PriceMsal = 6,
                PriceLsal = 8,
                //QtyS = orderPizza.QtySsal,
                //QtyM = orderPizza.QtyMsal,
                //QtyL = orderPizza.QtyLsal,

                pizzaTypePep = "Pepperoni",
                PriceSpep = 2,
                PriceMpep = 5,
                PriceLpep = 7,
                //QtyS = orderPizza.QtySpep,
                //QtyM = orderPizza.QtyMpep,
                //QtyL = orderPizza.QtyLpep,

                pizzaTypeMus = "Mushroom",
                PriceSmus = 2,
                PriceMmus = 4,
                PriceLmus = 6,
                //QtyS = orderPizza.QtySmus,
                //QtyM = orderPizza.QtyMmus,
                //QtyL = orderPizza.QtyLmus,

                pizzaTypeChe = "Cheese",
                PriceSche = 2,
                PriceMche = 4,
                PriceLche = 6,
                //QtyS = orderPizza.QtySche,
                //QtyM = orderPizza.QtyMche,
                //QtyL = orderPizza.QtyLche,

                pizzaTypeChk = "Chicken",
                PriceSchk = 2,
                PriceMchk = 4,
                PriceLchk = 6,
                //QtyS = orderPizza.QtySchk,
                //QtyM = orderPizza.QtyMchk,
                //QtyL = orderPizza.QtyLchk,
                OrderDate = DateTime.Now

            };
            //ViewBag.OrderPizzaCustomer = OrderPizzasList;
            return View(OrderPizzasList);
        }

        // POST: OrderPizzaCustomers1/CreateOrderPizza
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrderPizza([Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,QtySche,QtyMche,QtyLche,QtySchk,QtyMchk,QtyLchk,PriceSbac,PriceMbac,PriceLbac,PriceSsal,PriceMsal,PriceLsal,PriceSpep,PriceMpep,PriceLpep,PriceSmus,PriceMmus,PriceLmus,PriceSche,PriceMche,PriceLche,PriceSchk,PriceMchk,PriceLchk,pizzaTypeBac,pizzaTypeSal,pizzaTypePep,pizzaTypeMus,pizzaTypeChe,pizzaTypeChk,customerId,orderId,OrderDate,totalPrice")] OrderPizzaCustomer orderPizzaCustomer)
        {

            orderPizzaCustomer.OrderDate = DateTime.Now;
            //orderPizzaCustomer.
            #region Set the total price
            orderPizzaCustomer.totalPrice = (orderPizzaCustomer.QtySbac * orderPizzaCustomer.PriceSbac) +
                                            (orderPizzaCustomer.QtySsal * orderPizzaCustomer.PriceSsal) +
                                            (orderPizzaCustomer.QtySpep * orderPizzaCustomer.PriceSpep) +
                                            (orderPizzaCustomer.QtySmus * orderPizzaCustomer.PriceSmus) +
                                            (orderPizzaCustomer.QtySche * orderPizzaCustomer.PriceSche) +
                                            (orderPizzaCustomer.QtySchk * orderPizzaCustomer.PriceSchk) +
                                            (orderPizzaCustomer.QtyMbac * orderPizzaCustomer.PriceMbac) +
                                            (orderPizzaCustomer.QtyMsal * orderPizzaCustomer.PriceMsal) +
                                            (orderPizzaCustomer.QtyMpep * orderPizzaCustomer.PriceMpep) +
                                            (orderPizzaCustomer.QtyMmus * orderPizzaCustomer.PriceMmus) +
                                            (orderPizzaCustomer.QtyMche * orderPizzaCustomer.PriceMche) +
                                            (orderPizzaCustomer.QtyMchk * orderPizzaCustomer.PriceMchk) +
                                            (orderPizzaCustomer.QtyLbac * orderPizzaCustomer.PriceLbac) +
                                            (orderPizzaCustomer.QtyLsal * orderPizzaCustomer.PriceLsal) +
                                            (orderPizzaCustomer.QtyLpep * orderPizzaCustomer.PriceLpep) +
                                            (orderPizzaCustomer.QtyLmus * orderPizzaCustomer.PriceLmus) +
                                            (orderPizzaCustomer.QtyLche * orderPizzaCustomer.PriceLche) +
                                            (orderPizzaCustomer.QtyLchk * orderPizzaCustomer.PriceLchk);
            #endregion
            orderPizzaCustomer.customerId = 1;
            return View("Views/OrderPizzaCustomers1/Create.cshtml", orderPizzaCustomer);
        }

      
    }
}
