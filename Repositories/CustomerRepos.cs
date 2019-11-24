using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Models;

namespace VMANpizza.Repositories
{
    public class CustomerRepos
    {
        private AppDbContext _context;
        public CustomerRepos(AppDbContext ctx)
        {
            _context = ctx;
        }


        [HttpPost]
        public async Task<Customer> GetCustomer(string email)
        {
           var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Email == email);
            return customer;
        }
    }
}
