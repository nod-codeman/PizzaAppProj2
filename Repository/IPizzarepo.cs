using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Models;

namespace VMANpizza.Repository
{
    interface IPizzarepo
    {
        Task<List<Pizza>> Get();
        Task<Pizza> Get(int id);

        Task<bool> Create(Pizza pizza);
        Task<bool> Edit(int id, Pizza pizza);
        Task<bool> Delete(int id);
        bool PizzaExists(int id);
    }
}
