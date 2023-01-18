using System.Net;
using System.Xml.Linq;
using Session_07;

internal class Program {
    private static void Main(string[] args) {

        // REWRITE THE PROGRAM!

        Console.WriteLine("REWRITE THE PROGRAM!");

        Console.ReadLine();

    }

}



public class ActionRequest {

    public Guid RequestID { get; set; }
    public string? Input { get; set; }
    public ActionEnum Action { get; set; }

}

public class ActionResponse {

    public Guid RequestID { get; set; }
    public Guid ResponseID { get; set; }
    public string? Output { get; set; }

}

public class ActionResolver {

    public MessageLogger Logger { get; set; }

    public void Execute(ActionRequest request) {

    }

}

public class MessageLogger {

    public Message[]? Messages { get; set; }

    public void ReadAll() {}
    public void Clear() { }
    public void Write(Message message) { }

}

public class Message {

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