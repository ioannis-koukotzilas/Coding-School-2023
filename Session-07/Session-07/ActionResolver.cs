using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07 {

    public class ActionResolver {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // METHODS
        // ActionResponse Execute ActionRequest
        public ActionResponse Execute(ActionRequest request) {

            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;

            Logger = new MessageLogger();

            Log("EXECUTION START");

            try {
                switch (request.Action) {
                    case ActionEnum.Convert:
                        Log("CONVERT");
                        response.Output = Convert(request.Input);
                        break;
                    case ActionEnum.Uppercase:
                        Logger.Write(new Message("UPPERCASE"));
                        response.Output = Uppercase(request.Input);
                        break;
                    case ActionEnum.Reverse:
                        Log("REVERSE");
                        response.Output = Reverse(request.Input);
                        break;
                    default:
                        // TODO: ERROR MESSAGE
                        Console.WriteLine("ERROR");
                        break;
                }
            } catch (Exception ex) {
                Logger.Write(new Message(ex.Message));
            } finally {
                Log("EXECUTION END");
            }

            return response;
        }

        private void Log(string text) {

            Logger.Write(new Message("-------------"));

            Message message = new Message(text);

            Logger.Write(message);

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
