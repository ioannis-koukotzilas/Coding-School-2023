using System.Net;
using System.Xml.Linq;
using Session_07;

internal class Program {
    private static void Main(string[] args) {

        ActionResolver resolver = new ActionResolver();

        { // UPPERCASE

            ActionRequest request = new ActionRequest();
            request.Action = ActionEnum.Uppercase;
            request.Input = "here is a multiword input";


            ActionResponse response = resolver.Execute(request);
            Console.WriteLine(response.Output);
        }

        { // REVERSE

            ActionRequest request = new ActionRequest();
            request.Action = ActionEnum.Reverse;
            request.Input = "sdrawkcab";

            ActionResponse response = resolver.Execute(request);
            Console.WriteLine(response.Output);
        }


        { // CONVERT

            ActionRequest request = new ActionRequest();
            request.Action = ActionEnum.Convert;
            request.Input = "123";

            ActionResponse response = resolver.Execute(request);
            Console.WriteLine(response.Output);
        }

        { // ERROR

            ActionRequest request = new ActionRequest();
            request.Action = ActionEnum.Convert;
            request.Input = "asdf234"; // Error message should be generated

            ActionResponse response = resolver.Execute(request);
            Console.WriteLine(response.Output);
        }

        Message msg = new Message();
        msg.Data = "Message 1";
        msg.printMessage();

        Message msg2 = new ErrorMessage();
        msg2.Data = "Message 2";
        msg2.printMessage();

        Console.ReadLine();
    }

}