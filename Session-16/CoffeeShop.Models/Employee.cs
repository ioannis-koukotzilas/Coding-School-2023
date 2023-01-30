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

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
        public decimal SalaryPerMonth { get; set; }

        public Employee(string name, string surname) {
            ID = Guid.NewGuid();
            Name = name;
            Surname = surname;
        }

    }
}
