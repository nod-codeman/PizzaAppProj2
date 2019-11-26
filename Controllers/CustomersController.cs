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

        [HttpGet]
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
                    var custEmail = await _apiController.Get(email);
                    if(custEmail == null)
                    {
                        //if registration was not successful, check and return erro massage
                        ModelState.AddModelError(string.Empty, "Invalid user. Please Try Again or Create new credentials.");
                        return View();
                    }
                    //redirect user to home page
                    return RedirectToAction("CreateOrderPizza", "OrderPizzas1");
                }
                else
                {
                     ModelState.AddModelError(string.Empty, "Login failed. Try Again!!!");
                    return View();
                }
            }
            return RedirectToAction("index", "home");
        }


        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }
    }
}
