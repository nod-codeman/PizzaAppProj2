using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMANpizza.Models;
using VMANpizza.Models.ViewModel;
using VMANpizza.Repositories;

namespace VMANpizza.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CustomerAPIController _apiController;

        public CustomersController(CustomerAPIController apiController)
        {
            //_context = context;
            _apiController = apiController;
        }

        // GET: Customers
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _repo.GetCustomer.ToListAsync());
        //}


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email)
        {
            //check if model is valid
            if (ModelState.IsValid)
            {

                if (email != null)
                {
                    //redirect user to home page
                    return RedirectToAction("CreateOrderPizza", "OrderPizzas1");
                }
                else
                {
                    //if registration was not successful, check and return erro massage
                    ModelState.AddModelError(string.Empty, "Invalid user. Login failed.");
                    return View();

                }
            }
            return RedirectToAction("index", "home");
        }

        //// GET: Customers/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customer = await _context.Customers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(customer);
        //}

        //// GET: Customers/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Customers/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Email")] Customer customer)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var current_email = await _context.Customers
        //        .FirstOrDefaultAsync(m => m.Email == customer.Email);
        //        if (current_email == null)
        //        {
        //            _context.Add(customer);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Create));
        //        }
        //    }
        //    return RedirectToAction("CreateOrderPizza", "OrderPizzas1");
        //    //return View("Views/OrderPizzas1/CreateOrderPizza.cshtml");

        //}

        //// GET: Customers/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customer = await _context.Customers.FindAsync(id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(customer);
        //}

        //// POST: Customers/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Email")] Customer customer)
        //{
        //    if (id != customer.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(customer);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CustomerExists(customer.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(customer);
        //}

        //// GET: Customers/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customer = await _context.Customers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(customer);
        //}

        //// POST: Customers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var customer = await _context.Customers.FindAsync(id);
        //    _context.Customers.Remove(customer);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CustomerExists(int id)
        //{
        //    return _context.Customers.Any(e => e.Id == id);
        //}
    }
}
