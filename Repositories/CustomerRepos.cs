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
        
        public async Task<Customer> GetCustomer(string email)
        {
           var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Email == email);
            return customer;
        }

        
        public async Task<bool> CreateCustomer(Customer customer)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();
            return true;
        }

        //check if customer exits in the DB.
        public bool CustomerExits(string email)
        {
            return _context.Customers.Any(e => e.Email == email);
        }
    }
}
