using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Models;
using CoffeeShop.MVC.Models.Customer;
using Microsoft.AspNetCore.Mvc;

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

        // GET: /Customer/Edit
        public ActionResult Edit(int id) {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerEditDto {
                Id = dbCustomer.Id,
                Code = dbCustomer.Code,
                Description = dbCustomer.Description
            };
            return View(model: viewCustomer);
        }

        // POST: /Customer/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditDto customer) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            dbCustomer.Code = customer.Code;
            dbCustomer.Description = customer.Description;
            _customerRepo.Update(id, dbCustomer);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Customer/Delete
        public ActionResult Delete(int id) {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerDeleteDto {
                Id = dbCustomer.Id,
                Code = dbCustomer.Code,
                Description = dbCustomer.Description

            };
            return View(model: viewCustomer);
        }

        // POST: /Customer/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            _customerRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }

}