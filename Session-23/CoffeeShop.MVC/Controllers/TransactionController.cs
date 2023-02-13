using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Models;
using CoffeeShop.MVC.Models.Transaction;
using CoffeeShop.MVC.Models.Customer;
using CoffeeShop.MVC.Models.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeeShop.MVC.Controllers {

    public class TransactionController : Controller {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo) {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
        }

        // GET: /Transaction
        public ActionResult Index() {
            var transaction = _transactionRepo.GetAll();
            return View(model: transaction);
        }

        // GET: /Transaction/Create
        public ActionResult Create() {
            var newTransaction = new TransactionCreateDto();
            var customers = _customerRepo.GetAll();
            foreach (var customer in customers) {
                newTransaction.CustomerList.Add(new SelectListItem(customer.Description, customer.Id.ToString()));
            }
            var employees = _employeeRepo.GetAll();
            foreach (var employee in employees) {
                newTransaction.EmployeeList.Add(new SelectListItem(employee.Surname, employee.Id.ToString()));
            }
            return View(model: newTransaction);
        }

        // POST: /Transaction/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transaction) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbTransaction = new Transaction(transaction.Date, transaction.TotalPrice, transaction.PaymentMethod);

            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;

            _transactionRepo.Add(dbTransaction);
            return RedirectToAction("Index");
        }

        // GET: /Transaction/Edit
        public ActionResult Edit(int id) {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var editTransaction = new TransactionEditDto {
                Id = dbTransaction.Id,
                Date = dbTransaction.Date,
                TotalPrice = dbTransaction.TotalPrice,
                PaymentMethod = dbTransaction.PaymentMethod,
                CustomerId = dbTransaction.CustomerId,
                EmployeeId = dbTransaction.EmployeeId
            };

            var customers = _customerRepo.GetAll();
            foreach (var customer in customers) {
                editTransaction.CustomerList.Add(new SelectListItem(customer.Description, customer.Id.ToString()));
            }

            var employees = _employeeRepo.GetAll();
            foreach (var employee in employees) {
                editTransaction.EmployeeList.Add(new SelectListItem(employee.Surname, employee.Id.ToString()));
            }

            return View(model: editTransaction);
        }

        // POST: /Transaction/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionEditDto transaction) {

            try {

                if (!ModelState.IsValid) {
                    return View();
                }

                var dbTransaction = _transactionRepo.GetById(id);
                if (dbTransaction == null) {
                    return NotFound();
                }

                dbTransaction.Date = transaction.Date;
                dbTransaction.TotalPrice = transaction.TotalPrice;
                dbTransaction.PaymentMethod = transaction.PaymentMethod;
                dbTransaction.CustomerId = transaction.CustomerId;
                dbTransaction.EmployeeId = transaction.EmployeeId;

                _transactionRepo.Update(id, dbTransaction);
                return RedirectToAction(nameof(Index));

            } catch {
                return View();
            }

        }

        // GET: /Transaction/Delete
        public ActionResult Delete(int id) {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var deleteTransaction = new TransactionDeleteDto {
                Date = dbTransaction.Date,
                TotalPrice = dbTransaction.TotalPrice,
                PaymentMethod = dbTransaction.PaymentMethod
            };
            return View(model: deleteTransaction);
        }

        // POST: /Transaction/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            _transactionRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }

}