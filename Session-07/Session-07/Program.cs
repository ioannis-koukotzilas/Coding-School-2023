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