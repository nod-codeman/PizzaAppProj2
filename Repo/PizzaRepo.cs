using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Models;

namespace VMANpizza.Repository
{
    public class PizzaRepo : IPizzarepo
    {
        private AppDbContext _context;
        public PizzaRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var pizza = _context.Pizzas.Find(id);
            _context.Pizzas.Remove(pizza);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Edit(int id, Pizza pizza)
        {
            _context.Pizzas.Update(pizza);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Pizza>> Get()
        {
            var pizzas = await _context.Pizzas.ToListAsync();
            return pizzas;
        }

        public async Task<Pizza> Get(int? id)
        {
           var pizza = await _context.Pizzas.FirstOrDefaultAsync(p => p.Id == id);

            return pizza; 
        }

        public bool PizzaExists(int id)
        {

            return _context.Pizzas.Any(p => p.Id == id); 
        }
    }
}
