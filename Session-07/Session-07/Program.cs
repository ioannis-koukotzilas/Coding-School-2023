using System.Net;
using System.Xml.Linq;
using Session_07;

internal class Program {
    private static void Main(string[] args) {

        Console.WriteLine("Enter:");

        ActionRequest request = new ActionRequest();

        Console.WriteLine($"ID:\t\t{request.RequestID}");
        Console.WriteLine($"Input:\t\t{request.Input}");

        ActionResponse response = new ActionResponse();
        ActionResolver resolver = new ActionResolver();
        // response = resolver.Execute(request);

        Console.ReadLine();
    }
}