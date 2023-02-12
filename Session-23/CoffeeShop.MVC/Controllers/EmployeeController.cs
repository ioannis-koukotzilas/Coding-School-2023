using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Models;
using CoffeeShop.MVC.Models.Employee;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.MVC.Controllers {

    public class EmployeeController : Controller {

        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }

        // GET: /Employee
        public ActionResult Index() {
            var employees = _employeeRepo.GetAll();
            return View(model: employees);
        }

        // GET: /Employee/Create
        public ActionResult Create() {
            return View();
        }

        // POST: /Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreateDto employee) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbEmployee = new Employee(employee.Name, employee.Surname, employee.SalaryPerMonth, employee.EmployeeType);
            _employeeRepo.Add(dbEmployee);
            return RedirectToAction("Index");
        }

        // GET: /Employee/Edit
        public ActionResult Edit(int id) {
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null) {
                return NotFound();
            }

            var viewEmployee = new EmployeeEditDto {
                Id = dbEmployee.Id,
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname,
                SalaryPerMonth = dbEmployee.SalaryPerMonth,
                EmployeeType = dbEmployee.EmployeeType
            };
            return View(model: viewEmployee);
        }

        // POST: /Employee/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeEditDto employee) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null) {
                return NotFound();
            }

            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            dbEmployee.EmployeeType = employee.EmployeeType;
            _employeeRepo.Update(id, dbEmployee);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Employee/Delete
        public ActionResult Delete(int id) {
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null) {
                return NotFound();
            }

            var viewEmployee = new EmployeeDeleteDto {
                Id = dbEmployee.Id,
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname,
                SalaryPerMonth = dbEmployee.SalaryPerMonth,
                EmployeeType = dbEmployee.EmployeeType

            };
            return View(model: viewEmployee);
        }

        // POST: /Employee/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            _employeeRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }

}