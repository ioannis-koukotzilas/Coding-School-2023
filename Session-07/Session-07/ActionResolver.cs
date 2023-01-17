using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07 {

    public class ActionResolver : ActionResponse {

        public MessageLogger Logger { get; set; } = new MessageLogger();

        public ActionResponse Execute(ActionRequest request) {

            // Make an empty result/response
            ActionResponse response = new ActionResponse();
            // Assign the request id from the request to the response
            response.RequestID = request.RequestID;

            switch (request.Action) {
                case ActionEnum.Convert: {
                        // Try and process input
                        // response.Output = "101010101"
                        Console.WriteLine("Convert");
                    }
                    break;
                case ActionEnum.Uppercase: {
                        // Try and process input
                        // request.Input = "this is some superlong string"
                        // response.Output = "SUPERLONG"
                        Console.WriteLine("Uppercase");
                    }
                    break;
                case ActionEnum.Reverse: {
                        // Try and process input
                        // response.Input = "Some string"
                        // response.Output = "gnirts emoS"
                        Console.WriteLine("Reverse");
                    }
                    break;
                default: {
                        ErrorMessage error = new ErrorMessage();
                        error.Data = "Invalid action received";
                        Logger.Write(error);
                    }
                    break;
            }

            return response;
        }

    }

}
