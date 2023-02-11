using System;

namespace CoffeeShop.Models {

    public enum EmployeeTypeEnum {
        Manager,
        Cashier,
        Barista,
        Waiter
    }

    public class Employee {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }

        // Relation (one with many): Transactions per Employee
        public List<Transaction> Transactions { get; set; }

        public Employee(string name, string surname, int salaryPerMonth, EmployeeTypeEnum employeeType) {
            Name = name;
            Surname = surname;
            SalaryPerMonth = salaryPerMonth;
            EmployeeType = employeeType;
            Transactions = new List<Transaction>();
        }

    }

}