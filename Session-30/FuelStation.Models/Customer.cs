namespace FuelStation.Models {

    public class Customer {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }

        public List<Transaction> Transactions {get; set;}

        public Customer(string name, string surname, string cardNumber) {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
            Transactions = new List<Transaction>();
        }

    }

}