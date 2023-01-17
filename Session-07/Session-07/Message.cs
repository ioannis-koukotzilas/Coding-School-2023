using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07 {

    public class Message {

        public Guid ID { get; set; } = Guid.NewGuid();
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public string? Data { get; set; }

        public virtual void printMessage() {
            Console.WriteLine(Data);
        }

        public Message() { }

    }

    public class ErrorMessage : Message {

        public override void printMessage() {
            Console.Write("Error: ");
            Console.WriteLine(Data);
        }

    }

}
