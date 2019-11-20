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
    public class OrderPizzaCustomersController : Controller
    {
        private readonly AppDbContext _context;

        public OrderPizzaCustomersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OrderPizzaCustomers
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrderPizzaCustomer.ToListAsync());
        }

        // GET: OrderPizzaCustomers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPizzaCustomer = await _context.OrderPizzaCustomer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderPizzaCustomer == null)
            {
                return NotFound();
            }

            return View(orderPizzaCustomer);
        }

        // GET: OrderPizzaCustomers/Create
        //public IActionResult Create(/*OrderPizzaCustomer orderPizzaCustomer*/)
        //{
        //    //ViewBag.pizzaBac = PizzasList[0];
        //    //ViewBag.pizzaSal = PizzasList[1];
        //    //ViewBag.pizzaPep = PizzasList[2];
        //    //ViewBag.pizzaMus = PizzasList[3];
        //    return View();
        //}

        // POST: OrderPizzaCustomers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,QtySche,QtyMche,QtyLche,QtySchk,QtyMchk,QtyLchk,PriceSbac,PriceMbac,PriceLbac,PriceSsal,PriceMsal,PriceLsal,PriceSpep,PriceMpep,PriceLpep,PriceSmus,PriceMmus,PriceLmus,PriceSche,PriceMche,PriceLche,PriceSchk,PriceMchk,PriceLchk,pizzaTypeBac,pizzaTypeSal,pizzaTypePep,pizzaTypeMus,pizzaTypeChe,pizzaTypeChk,customerId,orderId,cartId,OrderDate,totalPrice")] OrderPizzaCustomer orderPizzaCustomer)
        {
            var OrderId = await _context.Orders.ToListAsync();
            int currOrderId;
            if (OrderId.Count != 0)
            {
                currOrderId = OrderId.Max(o => o.Id) + 1;
            }else 
            { currOrderId = 1; }
            if (ModelState.IsValid)
            {
                if (orderPizzaCustomer.QtySbac != 0 || orderPizzaCustomer.QtyMbac != 0 || orderPizzaCustomer.QtyLbac != 0)
                {
                    Pizza bacPizza = new Pizza() {
                        PizzaType = orderPizzaCustomer.pizzaTypeBac,
                        QtyS = orderPizzaCustomer.QtySbac,
                        QtyM = orderPizzaCustomer.QtyMbac,
                        QtyL = orderPizzaCustomer.QtyLbac,
                        OrderId = currOrderId
                    };                   
                    _context.Add(bacPizza);
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
                }
                Order order = new Order()
                {
                    totalPrice = orderPizzaCustomer.totalPrice,
                    OrderDate = orderPizzaCustomer.OrderDate
                };
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(/*orderPizzaCustomer*/);
        }

        // GET: OrderPizzaCustomers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPizzaCustomer = await _context.OrderPizzaCustomer.FindAsync(id);
            if (orderPizzaCustomer == null)
            {
                return NotFound();
            }
            return View(orderPizzaCustomer);
        }

        // POST: OrderPizzaCustomers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,PriceSbac,PriceMbac,PriceLbac,PriceSsal,PriceMsal,PriceLsal,PriceSpep,PriceMpep,PriceLpep,PriceSmus,PriceMmus,PriceLmus,pizzaTypeBac,pizzaTypeSal,pizzaTypePep,pizzaTypeMus,customerId,orderId,cartId,OrderDate,totalPrice")] OrderPizzaCustomer orderPizzaCustomer)
        {
            if (id != orderPizzaCustomer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderPizzaCustomer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderPizzaCustomerExists(orderPizzaCustomer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(orderPizzaCustomer);
        }

        // GET: OrderPizzaCustomers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPizzaCustomer = await _context.OrderPizzaCustomer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderPizzaCustomer == null)
            {
                return NotFound();
            }

            return View(orderPizzaCustomer);
        }

        // POST: OrderPizzaCustomers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderPizzaCustomer = await _context.OrderPizzaCustomer.FindAsync(id);
            _context.OrderPizzaCustomer.Remove(orderPizzaCustomer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderPizzaCustomerExists(int id)
        {
            return _context.OrderPizzaCustomer.Any(e => e.Id == id);
        }

        // GET: OrderPizzaCustomers/Create
        public IActionResult CreateOrderPizza(/*List<Pizza> PizzasList*/)
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
            //return View();
        }

        // POST: OrderPizzaCustomers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrderPizza([Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,QtySche,QtyMche,QtyLche,QtySchk,QtyMchk,QtyLchk,PriceSbac,PriceMbac,PriceLbac,PriceSsal,PriceMsal,PriceLsal,PriceSpep,PriceMpep,PriceLpep,PriceSmus,PriceMmus,PriceLmus,pizzaTypeBac,pizzaTypeSal,pizzaTypePep,pizzaTypeMus,customerId,orderId,cartId,OrderDate,totalPrice")] OrderPizzaCustomer orderPizzaCustomer)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Add(orderPizzaCustomer);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            orderPizzaCustomer.OrderDate = DateTime.Now;
            //orderPizzaCustomer.
            return View("Views/OrderPizzaCustomers/Create.cshtml", orderPizzaCustomer);
            //return View(orderPizzaCustomer);
        }
    }
}
