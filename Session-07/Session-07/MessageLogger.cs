using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {

    public class MessageLogger {

        // PROPERTIES
        public Message[]? Messages { get; set; }

        // CTOR
        public MessageLogger() {
            Messages = new Message[1000];
        }

        // METHODS
        public void ReadAll() {

        }
        public void Clear() {

        }
        public void Write(Message message) {

        }

    }

}
