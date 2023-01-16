using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {

    public class Institute {

        // Properties

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int YearsInService { get; set; }

        // Constructors

        public Institute() { }

        public Institute(Guid id) : this() {
            ID = id;
        }

        public Institute(Guid id, string name) : this(id) {
            Name = name;
        }

        public Institute(Guid id, string name, int yearsInService) : this(id, name) {
            YearsInService = yearsInService;
        }

        // Methods

        public void GetName() { }

        public void SetName(string Name) { }

        public void GetMessage(string Name, int YearsInService) {
            Console.WriteLine($"Institute name is {Name} and have {YearsInService} years in service.");
        }

    }

}
