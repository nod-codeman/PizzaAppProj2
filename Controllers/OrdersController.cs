using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMANpizza.Models;
using VMANpizza.Models.ViewModel;
using VMANpizza.Repository;

namespace VMANpizza.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderRepo _repo;

        public OrdersController(IOrderRepo repo)
        {
            _repo = repo;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(await _repo.Get());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _repo.Get(id);
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
                
                await _repo.Create(order);
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

            var order = await _repo.Get(id);
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
                    
                    await _repo.Edit(id, order);
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

            var order = await _repo.Get(id);
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
            await _repo.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _repo.OrderExists(id);
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
