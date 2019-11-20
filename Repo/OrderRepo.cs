using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Models;

namespace VMANpizza.Repository
{
    public class OrderRepo : IOrderRepo
    {
        private AppDbContext _context;

        public OrderRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var order = _context.Orders.Find(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Edit(int id, Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            
            return true;
        }

        public async Task<List<Order>> Get()
        {
            var orders = await _context.Orders.ToListAsync();

            return orders;
        }

        public async Task<Order> Get(int? id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);

            return order;
        }

        public bool OrderExists(int id)
        {
            return _context.Orders.Any(o => o.Id == id);
        }
    }
}
