using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.Services {

    public interface ILoginService {

        public string? Role { get; set; }
        EmployeeType EmployeeType { get; set; }
        bool Login(string username, string password);

    }

    public class LoginService : ILoginService {

        private string? _username;
        private string? _password;
        public string? Role { get; set; }
        public EmployeeType EmployeeType { get; set; }

        public bool Login(string username, string password) {

            _username = username;
            _password = password;

            if (_username == "manager" && _password == "codingschool2023") {
                Role = "Manager";
                EmployeeType = EmployeeType.Manager;
                return true;
            } else if (_username == "cashier" && _password == "codingschool2023") {
                Role = "Cashier";
                EmployeeType = EmployeeType.Cashier;
                return true;
            } else if (_username == "staff" && _password == "codingschool2023") {
                Role = "Staff";
                EmployeeType = EmployeeType.Staff;
                return true;
            }

            return false;

        }

    }

}