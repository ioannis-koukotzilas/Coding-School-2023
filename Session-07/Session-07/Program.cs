using System.Net;
using System.Xml.Linq;
using Session_07;

internal class Program {
    private static void Main(string[] args) {

        ActionRequest request = new ActionRequest() {
            Input = "Ioannis",
            Action = ActionEnum.Reverse
        };

        ActionResponse response = new ActionResponse();

        ActionResolver resolver = new ActionResolver();

        // Resolver get requests and returns responses
        response = resolver.Execute(request);

        foreach (Message message in resolver.Logger.Messages) {

            if (message != null) {
                Console.WriteLine(message.MessageText);
            }

        }

        Console.ReadLine();

    }

}