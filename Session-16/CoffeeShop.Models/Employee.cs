using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models {

    public enum EmployeeTypeEnum {
        Manager,
        Cashier,
        Barista,
        Waiter
    }

    public class Employee {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
        public decimal SalaryPerMonth { get; set; }

        public Transaction Transaction { get; set; } = null!; // Navigation property

        public Employee(string name, string surname) {
            Name = name;
            Surname = surname;
        }  

    }
}
