using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07 {

    public class ActionResolver {

        // PROPERTIES
        public MessageLogger? Logger { get; set; }

        // METHODS
        // ActionResponse Execute ActionRequest
        public ActionResponse Execute(ActionRequest request) {

            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;

            MessageLogger logger = new MessageLogger();

            Message message = new Message("EXECUTION START");
            logger.Messages[0] = message;

            try {
                switch (request.Action) {
                    case ActionEnum.Convert:
                        response.Output = Convert(request.Input);
                        break;
                    case ActionEnum.Uppercase:
                        response.Output = Uppercase(request.Input);
                        break;
                    case ActionEnum.Reverse:
                        response.Output = Reverse(request.Input);
                        break;
                    default:
                        // TODO: ERROR MESSAGE
                        Console.WriteLine("ERROR");
                        break;
                }
            } catch (Exception ex) {
                Message message2 = new Message(ex.Message);
                logger.Messages[1] = message2;
            } finally {
                Message message3 = new Message("EXECUTION END");
                logger.Messages[2] = message3;
            }

            return response;
        }

        public string Convert(string input) {
            // "Convert" you must check if the Input is a decimal number and convert it to binary.
            return string.Empty;

        }

        public string Uppercase(string input) {
            // "Uppercase" you must check if the Input is a string and has more than one words (separated by a space), then find the longest word in the Input string and convert it to uppercase.
            return string.Empty;
        }

        public string Reverse(string input) {
            // "Reverse" you must check if the Input is a string and reverse it.
            return string.Empty;
        }

    }

}
