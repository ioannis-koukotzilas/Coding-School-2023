using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {

    public class MessageLogger {

        public Message[] Messages { get; set; } = new Message[0];

        public void ReadAll() {
            foreach (Message msg in Messages) {
                msg.printMessage();
            }
        }

        public void Clear() {
            Messages = new Message[0];
        }

        public void Write(Message message) {
            Messages.Append(message);
        }

    }

}
