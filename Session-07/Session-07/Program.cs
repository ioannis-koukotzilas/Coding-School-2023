using System.Net;
using System.Xml.Linq;
using Session_07;

internal class Program {
    private static void Main(string[] args) {

        // REWRITE THE PROGRAM!

        ActionRequest request = new ActionRequest();

        ActionResponse response = new ActionResponse();

        Console.WriteLine(response.RequestID);
        Console.WriteLine(response.ResponseID);
        Console.WriteLine(response.Output);

        ActionResolver resolver = new ActionResolver();

        // Resolver get requests and returns responses
        response = resolver.Execute(request);

       

        Console.WriteLine("REWRITE THE PROGRAM!");

        Console.ReadLine();

    }

}

public enum ActionEnum {
    Convert,
    Uppercase,
    Reverse
}


public class ActionRequest {

    // Properties
    public Guid RequestID { get; set; }
    public string? Input { get; set; }
    public ActionEnum Action { get; set; }

    // CTOR
    public ActionRequest() {
        RequestID = Guid.NewGuid();
    }

}

public class ActionResponse {

    // Properties
    public Guid RequestID { get; set; }
    public Guid ResponseID { get; set; }
    public string? Output { get; set; } = "This is a response";

    // CTOR
    public ActionResponse() {
        ResponseID = Guid.NewGuid();
    }

}

public class ActionResolver {

    // Properties
    public MessageLogger? Logger { get; set; }

    // Methods
    // ActionResponse Execute ActionRequest
    public ActionResponse Execute(ActionRequest request) {

        ActionResponse response = new ActionResponse();
        response.ResponseID = Guid.NewGuid();
        response.RequestID = request.RequestID;

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
                    // TODO: Error msg
                    Console.WriteLine("ERROR");
                    break;
            }

        } catch (Exception ex) {

            throw;
        }

        return response;
    }

    public string Convert(string input) {
        // “Convert”youmustcheckiftheInputisadecimalnumberandconvert it to binary.
        return string.Empty;
        
    }

    public string Uppercase(string input) {
        // “Uppercase”youmustcheckiftheInputisastringandhasmorethan one words (separated by a space), then find the longest word in the Input string and convert it to uppercase.
        return string.Empty;
    }

    public string Reverse(string input) {
        // “Reverse” you must check if the Input is a string and reverse it.
        return string.Empty;
    }

}

public class MessageLogger {

    // Properties
    public Message[]? Messages { get; set; }

    // CTOR
    public MessageLogger() {
        Messages = new Message[1000];
    }

    // Methods
    public void ReadAll() {
    
    }
    public void Clear() {
    
    }
    public void Write(Message message) {
    
    }

}

public class Message {

    // Properties
    public Guid ID { get; set; }
    public DateTime TimeStamp { get; set; }
    public string? MessageText { get; set; }

}






































//ActionResolver resolver = new ActionResolver();

//{ // UPPERCASE

//    ActionRequest request = new ActionRequest();
//    request.Action = ActionEnum.Uppercase;
//    request.Input = "here is a multiword input";


//    ActionResponse response = resolver.Execute(request);
//    Console.WriteLine(response.Output);
//}

//{ // REVERSE

//    ActionRequest request = new ActionRequest();
//    request.Action = ActionEnum.Reverse;
//    request.Input = "sdrawkcab";

//    ActionResponse response = resolver.Execute(request);
//    Console.WriteLine(response.Output);
//}


//{ // CONVERT

//    ActionRequest request = new ActionRequest();
//    request.Action = ActionEnum.Convert;
//    request.Input = "123";

//    ActionResponse response = resolver.Execute(request);
//    Console.WriteLine(response.Output);
//}

//{ // ERROR

//    ActionRequest request = new ActionRequest();
//    request.Action = ActionEnum.Convert;
//    request.Input = "asdf234"; // Error message should be generated

//    ActionResponse response = resolver.Execute(request);
//    Console.WriteLine(response.Output);
//}

//Message msg = new Message();
//msg.Data = "Message 1";
//msg.printMessage();

//Message msg2 = new ErrorMessage();
//msg2.Data = "Message 2";
//msg2.printMessage();