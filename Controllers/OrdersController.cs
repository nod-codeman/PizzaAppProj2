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
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerId,OrderDate,totalPrice")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerId,OrderDate,totalPrice")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
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
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }

        public IActionResult ConfirmOrder(List<Pizza> PizzasList)
        {
            
            return View(PizzasList);
        }

        //// POST: Orders/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        ////public async Task<IActionResult> ConfirmOrder([Bind("Id,CustomerId,OrderDate,totalPrice")] Order order)
        //public async Task<IActionResult> ConfirmOrder(List<Order> PizzasList)
        //{
        //    //List<Pizza> PizzasList = new List<Pizza>
        //    //{
        //    //new Pizza()
        //    //{
        //    //    PizzaType = "Bacon",
        //    //    PriceS = 2,
        //    //    PriceM = 5,
        //    //    PriceL = 7,
        //    //    QtyS = orderPizza.QtySbac,
        //    //    QtyM = orderPizza.QtyMbac,
        //    //    QtyL = orderPizza.QtyLbac,
        //    //},
        //    //new Pizza()
        //    //{
        //    //    PizzaType = "Salami",
        //    //    PriceS = 3,
        //    //    PriceM = 6,
        //    //    PriceL = 8,
        //    //    QtyS = orderPizza.QtySsal,
        //    //    QtyM = orderPizza.QtyMsal,
        //    //    QtyL = orderPizza.QtyLsal,
        //    //},
        //    //new Pizza()
        //    //{
        //    //    PizzaType = "Pepperoni",
        //    //    PriceS = 2,
        //    //    PriceM = 5,
        //    //    PriceL = 7,
        //    //    QtyS = orderPizza.QtySpep,
        //    //    QtyM = orderPizza.QtyMpep,
        //    //    QtyL = orderPizza.QtyLpep,
        //    //},
        //    //new Pizza()
        //    //{
        //    //    PizzaType = "Mushroom",
        //    //    PriceS = 2,
        //    //    PriceM = 4,
        //    //    PriceL = 6,
        //    //    QtyS = orderPizza.QtySmus,
        //    //    QtyM = orderPizza.QtyMmus,
        //    //    QtyL = orderPizza.QtyLmus,
        //    //}
        //    //};
        //    //if (ModelState.IsValid)
        //    //{
        //    //    _context.Add(PizzasList[0]);
        //    //    _context.Add(PizzasList[1]);
        //    //    _context.Add(PizzasList[2]);
        //    //    _context.Add(PizzasList[3]);
        //    //    await _context.SaveChangesAsync();
        //    //    return RedirectToAction(nameof(Index));
        //    //}
        //    return View();
        //}
    }
}
