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
    public class OrderPizzasController : Controller
    {
        private readonly AppDbContext _context;

        public OrderPizzasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OrderPizzas
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrderPizza.ToListAsync());
        }

        // GET: OrderPizzas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPizza = await _context.OrderPizza
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderPizza == null)
            {
                return NotFound();
            }

            return View(orderPizza);
        }

        // GET: OrderPizzas/Create
        public IActionResult Create()
        {
            OrderPizza orderPizza = new OrderPizza();
            orderPizza.QtySbac = 0;
            return View(orderPizza);
            //return View();
        }

        // POST: OrderPizzas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,customerId,orderId")] OrderPizza orderPizza)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Add(orderPizza);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            List<Pizza> PizzasList = new List<Pizza>
            {
            new Pizza()
            {
                PizzaType = "Bacon",
                PriceS = 2,
                PriceM = 5,
                PriceL = 7,
                QtyS = orderPizza.QtySbac,
                QtyM = orderPizza.QtyMbac,
                QtyL = orderPizza.QtyLbac,
            },
            new Pizza()
            {
                PizzaType = "Salami",
                PriceS = 3,
                PriceM = 6,
                PriceL = 8,
                QtyS = orderPizza.QtySsal,
                QtyM = orderPizza.QtyMsal,
                QtyL = orderPizza.QtyLsal,
            },
            new Pizza()
            {
                PizzaType = "Pepperoni",
                PriceS = 2,
                PriceM = 5,
                PriceL = 7,
                QtyS = orderPizza.QtySpep,
                QtyM = orderPizza.QtyMpep,
                QtyL = orderPizza.QtyLpep,
            },
            new Pizza()
            {
                PizzaType = "Mushroom",
                PriceS = 2,
                PriceM = 4,
                PriceL = 6,
                QtyS = orderPizza.QtySmus,
                QtyM = orderPizza.QtyMmus,
                QtyL = orderPizza.QtyLmus,
            }
            };
            return View("Views/Pizzas/ConfirmOrderPizzas.cshtml", PizzasList);
            //return View(orderPizza);
        }

        // GET: OrderPizzas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPizza = await _context.OrderPizza.FindAsync(id);
            if (orderPizza == null)
            {
                return NotFound();
            }
            return View(orderPizza);
        }

        // POST: OrderPizzas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,customerId,orderId")] OrderPizza orderPizza)
        {
            if (id != orderPizza.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderPizza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderPizzaExists(orderPizza.Id))
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
            return View(orderPizza);
        }

        // GET: OrderPizzas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPizza = await _context.OrderPizza
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderPizza == null)
            {
                return NotFound();
            }

            return View(orderPizza);
        }

        // POST: OrderPizzas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderPizza = await _context.OrderPizza.FindAsync(id);
            _context.OrderPizza.Remove(orderPizza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderPizzaExists(int id)
        {
            return _context.OrderPizza.Any(e => e.Id == id);
        }


        // GET: OrderPizzas/Create
        public IActionResult CreateOrderPizza()
        {
            OrderPizza orderPizza = new OrderPizza();
            orderPizza.QtySbac = 0;
            return View(orderPizza);
        }

        // POST: OrderPizzas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrderPizza([Bind("Id,QtySbac,QtyMbac,QtyLbac,QtySsal,QtyMsal,QtyLsal,QtySpep,QtyMpep,QtyLpep,QtySmus,QtyMmus,QtyLmus,customerId,orderId")] OrderPizza orderPizza)
        {
            List<Pizza> PizzasList = new List<Pizza>
            {
            new Pizza()
            {
                PizzaType = "Bacon",
                PriceS = 2,
                PriceM = 5,
                PriceL = 7,
                QtyS = orderPizza.QtySbac,
                QtyM = orderPizza.QtyMbac,
                QtyL = orderPizza.QtyLbac,
            },
            new Pizza()
            {
                PizzaType = "Salami",
                PriceS = 3,
                PriceM = 6,
                PriceL = 8,
                QtyS = orderPizza.QtySsal,
                QtyM = orderPizza.QtyMsal,
                QtyL = orderPizza.QtyLsal,
            },
            new Pizza()
            {
                PizzaType = "Pepperoni",
                PriceS = 2,
                PriceM = 5,
                PriceL = 7,
                QtyS = orderPizza.QtySpep,
                QtyM = orderPizza.QtyMpep,
                QtyL = orderPizza.QtyLpep,
            },
            new Pizza()
            {
                PizzaType = "Mushroom",
                PriceS = 2,
                PriceM = 4,
                PriceL = 6,
                QtyS = orderPizza.QtySmus,
                QtyM = orderPizza.QtyMmus,
                QtyL = orderPizza.QtyLmus,
            }
            };
            //return View("Views/Pizzas/ConfirmOrderPizzas.cshtml", PizzasList);
            return View("Views/OrderPizzaCustomers/CreateOrderPizza.cshtml", PizzasList);
        }

    }
}
