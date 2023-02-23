using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs.Transaction;
using FuelStation.Blazor.Shared.DTOs.Customer;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeerRepo;

        public TransactionController(

            IEntityRepo<Transaction> transactionRepo,
            IEntityRepo<Customer> customerRepo,
            IEntityRepo<Employee> employeerRepo) {

            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeerRepo = employeerRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> GetAll() {

            var dbTransactions = await _transactionRepo.GetAllAsync();

            var dbResponse = dbTransactions.Select(t => new TransactionListDto {

                Id = t.Id,
                Date = t.Date,
                PaymentMethod = t.PaymentMethod,
                TotalValue = t.TotalValue,

                EmployeeId = t.EmployeeId,
                CustomerId = t.Customer.Id,

                EmployeeName = t.Employee.Name,
                EmployeeSurname = t.Employee.Surname,
                EmployeeType = t.Employee.EmployeeType,

                CustomerName = t.Customer.Name,
                CustomerSurname = t.Customer.Surname

            });

            return dbResponse;
        }

        [HttpGet("edit/{id}")]
        public async Task<TransactionEditDto> GetById(int id) {

            var dbTransaction = await _transactionRepo.GetByIdAsync(id);

            if (dbTransaction == null) {
                throw new ArgumentNullException();
            }

            var dbResponse = new TransactionEditDto {

                Id = id,
                Date = dbTransaction.Date,
                PaymentMethod = dbTransaction.PaymentMethod,
                TotalValue = dbTransaction.TotalValue,

                EmployeeId = dbTransaction.EmployeeId,
                CustomerId = dbTransaction.CustomerId,

                // Rest



                //CustomerName = dbTransaction.Customer.Name,
                //CustomerSurname = dbTransaction.Customer.Surname,

                //EmployeeName = dbTransaction.Employee.Name,
                //EmployeeSurname = dbTransaction.Employee.Surname,


     



            };

            return dbResponse;
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction) {

            var dbTransaction = new Transaction(
               transaction.Date,
               transaction.PaymentMethod,
               transaction.TotalValue
              
               // Rest

                );

            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;

            await _transactionRepo.AddAsync(dbTransaction);
        }



        //[HttpPost]
        //public async Task Post(TodoEditDto todo) {
        //    var newTodo = new Todo(todo.Title);
        //    foreach (var comment in todo.Comments) {
        //        newTodo.Comments.Add(new TodoComment(comment.Text));
        //    }

        //    newTodo.TodoType = todo.TodoType;
        //    _todoRepo.Add(newTodo);
        //}





        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await _transactionRepo.DeleteAsync(id);
        }

    }

}