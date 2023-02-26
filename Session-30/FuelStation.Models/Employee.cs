using FuelStation.Models.Enums;

namespace FuelStation.Models {

    public class Employee {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        // Navigation properties
        public List<Transaction> Transactions { get; set; }

        public Employee(string name, string surname, DateTime hireDateStart, DateTime hireDateEnd, decimal sallaryPerMonth, EmployeeType employeeType) {
            Name = name;
            Surname = surname;
            HireDateStart = hireDateStart;
            HireDateEnd = hireDateEnd;
            SallaryPerMonth = sallaryPerMonth;
            EmployeeType = employeeType;
            Transactions = new List<Transaction>();
        }

    }

}