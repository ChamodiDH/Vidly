using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        [Route("customers/details/{id}/{name}")]
        public ActionResult Details(int id, String name) {

            var customer = new Customer
            {
                Id = id,
                Name = name

            };
            
            return View(customer);
        
        }


        // GET: Customer
        [Route("customers")]
        public ActionResult Customers()
        {
            var customerList = new List<Customer> {
                
                new Customer { Id = 1, Name="Customer 1"},
                 new Customer { Id = 2, Name="Customer 2"}

            };
            var viewModel = new CustomerViewModel { 
            
                Customers = customerList
            };
          
            return View(viewModel);
        }


    }
}