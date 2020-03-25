using MVC_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = GetCustomers();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(cust => cust.Id == id);
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id=1,Name="Steve Jobs"},
                new Customer{Id=2,Name="Bill Gates"}
            };
        }
    }
}