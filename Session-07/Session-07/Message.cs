using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07 {

    public class Message {

        // PROPERTIES
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? MessageText { get; set; }

        // CTOR
        public Message() {
            ID = Guid.NewGuid();
        }

        public Message(string text) {
            ID = Guid.NewGuid();
            TimeStamp = DateTime.Now;
            MessageText = text;
        }

    }

}
