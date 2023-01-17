using System.Net;
using System.Xml.Linq;
using Session_07;

internal class Program {
    private static void Main(string[] args) {

        Console.WriteLine("Enter something");

        ActionRequest request = new ActionRequest();

        //request.GetRequest();

        Console.WriteLine($"ID:\t\t{request.RequestID}");
        Console.WriteLine($"Input:\t\t{request.Input}");

        Console.ReadLine();
    }
}