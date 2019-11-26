using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VMANpizza.Models;
using VMANpizza.Repositories;

namespace VMANpizza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {
        private readonly CustomerRepos _repo;
        public CustomerAPIController(CustomerRepos repo)
        {
            _repo = repo;
        }
        // GET: api/CustomerAPI
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Nwojo", "Dike" };
        }

        // GET: api/CustomerAPI/5
        [HttpGet("{email}", Name = "Get")]
        public async Task<Customer> Get(string email)
        {
            return (await _repo.GetCustomer(email));
        }

        // POST: api/CustomerAPI/5
        //[HttpPost("{email}")]
        //public async Task<Customer> Create(string email)
        //{
        //    return (await _repo.CreateCustomer(email));
        //}

        //[HttpGet("{id}", Name = "Get")]
        //public async Task<Customer> Get(int id)
        //{
        //    return (await _repo.GetCustomer(id));
        //}



        // POST: api/CustomerAPI
        [HttpPost]
        public async void CreateCustomer([FromBody] Customer customer)
        {
            await _repo.CreateCustomer(customer);
        }

        [HttpPost]
        public bool CustomerExits([FromBody] Customer customer)
        {
            //if customer does not exist, then create a new customer
            return (_repo.CustomerExits(customer.Email));

        }

        // PUT: api/CustomerAPI/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
