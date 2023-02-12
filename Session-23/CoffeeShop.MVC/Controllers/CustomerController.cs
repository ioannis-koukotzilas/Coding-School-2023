using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Models;
using CoffeeShop.MVC.Models.Customer;
using Microsoft.AspNetCore.Mvc;





// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoffeeShop.MVC.Controllers {

    public class CustomerController : Controller {

        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo) {
            _customerRepo = customerRepo;
        }

        // GET: /Customer
        public ActionResult Index() {
            var customers = _customerRepo.GetAll();
            return View(model: customers);
        }

        // GET: /Customer/Create
        public ActionResult Create() {
            return View();
        }

        // POST: /Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateDto customer) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbCustomer = new Customer(customer.Code, customer.Description);
            _customerRepo.Add(dbCustomer);
            return RedirectToAction("Index");

        }




    }

}

