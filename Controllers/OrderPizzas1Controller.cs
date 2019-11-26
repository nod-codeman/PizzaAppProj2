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
    public class OrderPizzas1Controller : Controller
    {
        private readonly AppDbContext _context;

        public OrderPizzas1Controller(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }

        // POST: OrderPizzas1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,QtySche,QtyMche,QtyLche,QtySchk,QtyMchk,QtyLchk,PriceSbac,PriceMbac,PriceLbac,PriceSsal,PriceMsal,PriceLsal,PriceSpep,PriceMpep,PriceLpep,PriceSmus,PriceMmus,PriceLmus,PriceSche,PriceMche,PriceLche,PriceSchk,PriceMchk,PriceLchk,pizzaTypeBac,pizzaTypeSal,pizzaTypePep,pizzaTypeMus,pizzaTypeChe,pizzaTypeChk,customerId,orderId,OrderDate,totalPrice")] OrderPizza orderPizza)
        {
            orderPizza.pizzaTypeBac = "Bacon";
            orderPizza.pizzaTypePep = "Pepperoni";
            orderPizza.pizzaTypeSal = "Salami";
            orderPizza.pizzaTypeChe = "Cheese";
            orderPizza.pizzaTypeChk = "Chicken";
            orderPizza.pizzaTypeMus = "Mushroom";

            var CustId = await _context.Customers.ToListAsync();
            int currCustId;
            if (CustId.Count != 0)
            {
                currCustId = CustId.Max(c => c.Id);
            }
            else
            { currCustId = 1; }
            orderPizza.customerId = currCustId;

            var OrderId = await _context.Orders.ToListAsync();
            int currOrderId;
            if (OrderId.Count != 0)
            {
                currOrderId = OrderId.Max(o => o.Id) + 1;
            }
            else
            { currOrderId = 1; }
            if (ModelState.IsValid)
            {
                Order order = new Order()
                {
                    totalPrice = orderPizza.totalPrice,
                    OrderDate = orderPizza.OrderDate,
                    CustomerId = currCustId,
                    //Id = currCustId
                };
                _context.Add(order);
                //await _context.SaveChangesAsync();
                if (orderPizza.QtySbac != 0 || orderPizza.QtyMbac != 0 || orderPizza.QtyLbac != 0)
                {
                    Pizza bacPizza = new Pizza()
                    {
                        PizzaType = orderPizza.pizzaTypeBac,
                        QtyS = orderPizza.QtySbac,
                        QtyM = orderPizza.QtyMbac,
                        QtyL = orderPizza.QtyLbac,
                        OrderId = currOrderId
                    };
                    _context.Add(bacPizza);
                    //await _context.SaveChangesAsync();
                }
                if (orderPizza.QtySsal != 0 || orderPizza.QtyMsal != 0 || orderPizza.QtyLsal != 0)
                {
                    Pizza salPizza = new Pizza()
                    {
                        PizzaType = orderPizza.pizzaTypeSal,
                        QtyS = orderPizza.QtySsal,
                        QtyM = orderPizza.QtyMsal,
                        QtyL = orderPizza.QtyLsal,
                        OrderId = currOrderId
                    };
                    _context.Add(salPizza);
                    //await _context.SaveChangesAsync();
                }
                if (orderPizza.QtySpep != 0 || orderPizza.QtyMpep != 0 || orderPizza.QtyLpep != 0)
                {
                    Pizza pepPizza = new Pizza()
                    {
                        PizzaType = orderPizza.pizzaTypePep,
                        QtyS = orderPizza.QtySpep,
                        QtyM = orderPizza.QtyMpep,
                        QtyL = orderPizza.QtyLpep,
                        OrderId = currOrderId
                    };
                    _context.Add(pepPizza);
                    //await _context.SaveChangesAsync();
                }
                if (orderPizza.QtySmus != 0 || orderPizza.QtyMmus != 0 || orderPizza.QtyLmus != 0)
                {
                    Pizza musPizza = new Pizza()
                    {
                        PizzaType = orderPizza.pizzaTypeMus,
                        QtyS = orderPizza.QtySmus,
                        QtyM = orderPizza.QtyMmus,
                        QtyL = orderPizza.QtyLmus,
                        OrderId = currOrderId
                    };
                    _context.Add(musPizza);
                    //await _context.SaveChangesAsync();
                }
                if (orderPizza.QtySche != 0 || orderPizza.QtyMche != 0 || orderPizza.QtyLche != 0)
                {
                    Pizza chePizza = new Pizza()
                    {
                        PizzaType = orderPizza.pizzaTypeChe,
                        QtyS = orderPizza.QtySche,
                        QtyM = orderPizza.QtyMche,
                        QtyL = orderPizza.QtyLche,
                        OrderId = currOrderId
                    };
                    _context.Add(chePizza);
                    //await _context.SaveChangesAsync();
                }
                if (orderPizza.QtySchk != 0 || orderPizza.QtyMchk != 0 || orderPizza.QtyLchk != 0)
                {
                    Pizza chkPizza = new Pizza()
                    {
                        PizzaType = orderPizza.pizzaTypeBac,
                        QtyS = orderPizza.QtySchk,
                        QtyM = orderPizza.QtyMchk,
                        QtyL = orderPizza.QtyLchk,
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
            OrderPizza OrderPizzasList = new OrderPizza
            {
                pizzaTypeBac = "Bacon",
                PriceSbac = 8,
                PriceMbac = 12,
                PriceLbac = 17,

                pizzaTypeSal = "Salami",
                PriceSsal = 11,
                PriceMsal = 16,
                PriceLsal = 19,

                pizzaTypePep = "Pepperoni",
                PriceSpep = 7,
                PriceMpep = 11,
                PriceLpep = 14,

                pizzaTypeMus = "Mushroom",
                PriceSmus = 10,
                PriceMmus = 12,
                PriceLmus = 16,

                pizzaTypeChe = "Cheese",
                PriceSche = 5,
                PriceMche = 7,
                PriceLche = 11,

                pizzaTypeChk = "Chicken",
                PriceSchk = 10,
                PriceMchk = 12,
                PriceLchk = 16,
                OrderDate = DateTime.Now

            };
            return View(OrderPizzasList);
        }


        // POST: OrderPizzas1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrderPizza([Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,QtySche,QtyMche,QtyLche,QtySchk,QtyMchk,QtyLchk,PriceSbac,PriceMbac,PriceLbac,PriceSsal,PriceMsal,PriceLsal,PriceSpep,PriceMpep,PriceLpep,PriceSmus,PriceMmus,PriceLmus,PriceSche,PriceMche,PriceLche,PriceSchk,PriceMchk,PriceLchk,pizzaTypeBac,pizzaTypeSal,pizzaTypePep,pizzaTypeMus,pizzaTypeChe,pizzaTypeChk,customerId,orderId,OrderDate,totalPrice")] OrderPizza orderPizza)
        {
            orderPizza.OrderDate = DateTime.Now;
            #region Set the total price
            orderPizza.totalPrice = (orderPizza.QtySbac * orderPizza.PriceSbac) +
                                            (orderPizza.QtySsal * orderPizza.PriceSsal) +
                                            (orderPizza.QtySpep * orderPizza.PriceSpep) +
                                            (orderPizza.QtySmus * orderPizza.PriceSmus) +
                                            (orderPizza.QtySche * orderPizza.PriceSche) +
                                            (orderPizza.QtySchk * orderPizza.PriceSchk) +
                                            (orderPizza.QtyMbac * orderPizza.PriceMbac) +
                                            (orderPizza.QtyMsal * orderPizza.PriceMsal) +
                                            (orderPizza.QtyMpep * orderPizza.PriceMpep) +
                                            (orderPizza.QtyMmus * orderPizza.PriceMmus) +
                                            (orderPizza.QtyMche * orderPizza.PriceMche) +
                                            (orderPizza.QtyMchk * orderPizza.PriceMchk) +
                                            (orderPizza.QtyLbac * orderPizza.PriceLbac) +
                                            (orderPizza.QtyLsal * orderPizza.PriceLsal) +
                                            (orderPizza.QtyLpep * orderPizza.PriceLpep) +
                                            (orderPizza.QtyLmus * orderPizza.PriceLmus) +
                                            (orderPizza.QtyLche * orderPizza.PriceLche) +
                                            (orderPizza.QtyLchk * orderPizza.PriceLchk);
            #endregion

            var CustId = await _context.Customers.ToListAsync();
            int currCustId;
            if (CustId.Count != 0)
            {
                currCustId = CustId.Max(c => c.Id);
            }
            else
            { currCustId = 1; }
            orderPizza.customerId = Convert.ToInt32(currCustId) ;
            return View("Views/OrderPizzas1/Create.cshtml", orderPizza);
        }
    }
}
