using FuelStation.Blazor.Shared.DTOs.Employee;
using FuelStation.Blazor.Shared.DTOs.Customer;
using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.DTOs.Transaction {

    public class TransactionEditDto {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }


        // Remove?
        //public string EmployeeName { get; set; } = null!;
        //public string EmployeeSurname { get; set; } = null!;

        //public string CustomerName { get; set; } = null!;
        //public string CustomerSurname { get; set; } = null!;



        // WTF???
        //public CustomerListDto Customer { get; set; } = null!;
        //public EmployeeEditDto Employee { get; set; } = null!;


        public List<CustomerEditDto> Customers { get; set; } = new List<CustomerEditDto>();
        public List<EmployeeEditDto> Employees { get; set; } = new List<EmployeeEditDto>();




        public List<TransactionLineDto> TransactionLines { get; set; } = new();



        //public List<CustomerEditDto> Customers { get; set; } = new List<CustomerEditDto>();
        //public List<EmployeeEditDto> Employees { get; set; } = new List<EmployeeEditDto>();

        //public List<CustomerListDto> Customers { get; set; } = new();
        //public List<EmployeeListDto> Employees { get; set; } = new();

        //public string EmployeeName { get; set; } = null!;
        //public string EmployeeSurname { get; set; } = null!;
        //public EmployeeType EmployeeType { get; set; }

        //public string CustomerName { get; set; } = null!;
        //public string CustomerSurname { get; set; } = null!;

        //// TEST

        //public List<CustomerDto> Customers { get; set; } = new();
        //public List<EmployeeListDto> Employees { get; set; } = new();



        //public string EmployeeName { get; set; } = null!;
        //public string EmployeeSurname { get; set; } = null!;

        //public string CustomerName { get; set; } = null!;
        //public string CustomerSurname { get; set; } = null!;


    }


    public class TransactionLineDto {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }
    }


}