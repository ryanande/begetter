using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebUi.Models;

namespace WebUi.Controllers
{
    public class CustomerController : ApiController
    {
    [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return GetCustomers();
        }

    [HttpGet]
        public Customer Get(Guid id)
        {
            return GetCustomers().FirstOrDefault(c => c.Id == id);
        }

        [HttpPost]
        public HttpResponseMessage Post(Customer customer)
        {
            return null;
        }

        [HttpPut]
        public HttpResponseMessage Put(Customer customer)
        {
            return null;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(Guid id)
        {
            return null;
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{ Id = Guid.NewGuid(), FirstName = "Joe", LastName = "Schmoe", Email = "eat@joes.com"},
                new Customer{ Id = Guid.NewGuid(), FirstName = "John", LastName = "Doe", Email = "john@me.com"},
                new Customer{ Id = Guid.NewGuid(), FirstName = "David", LastName = "Sprinler", Email = "dave@water.com"}
            };
        } 
    }
}
