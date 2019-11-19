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
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderPizzaCustomers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,PriceSbac,PriceMbac,PriceLbac,PriceSsal,PriceMsal,PriceLsal,PriceSpep,PriceMpep,PriceLpep,PriceSmus,PriceMmus,PriceLmus,pizzaTypeBac,pizzaTypeSal,pizzaTypePep,pizzaTypeMus,customerId,orderId,cartId,OrderDate,totalPrice")] OrderPizzaCustomer orderPizzaCustomer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderPizzaCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderPizzaCustomer);
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
        public IActionResult CreateOrderPizza(List<Pizza> PizzasList)
        {
            ViewBag.pizzaBac = PizzasList[0];
            ViewBag.pizzaSal = PizzasList[1];
            ViewBag.pizzaPep = PizzasList[2];
            ViewBag.pizzaMus = PizzasList[3];
            return View();
        }

        // POST: OrderPizzaCustomers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrderPizza([Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,PriceSbac,PriceMbac,PriceLbac,PriceSsal,PriceMsal,PriceLsal,PriceSpep,PriceMpep,PriceLpep,PriceSmus,PriceMmus,PriceLmus,pizzaTypeBac,pizzaTypeSal,pizzaTypePep,pizzaTypeMus,customerId,orderId,cartId,OrderDate,totalPrice")] OrderPizzaCustomer orderPizzaCustomer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderPizzaCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderPizzaCustomer);
        }
    }
}
