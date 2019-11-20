using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Models;

namespace VMANpizza.Repository
{
    public interface IOrderRepo
    {
        Task<List<Order>> Get();
        Task<Order> Get(int? id);

        Task<bool> Create(Order order);
        Task<bool> Edit(int id, Order order);
        Task<bool> Delete(int id);
        bool OrderExists(int id);
    }
}
