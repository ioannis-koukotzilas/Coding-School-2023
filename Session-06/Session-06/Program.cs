using Session_06;
using System.Xml.Linq;

internal class Program {
    private static void Main(string[] args) {

        Person person = new Person();
        person.GetMessage("Petros", 29);

        Professor professor = new Professor();
        professor.GetMessage("Fotis", 45, "1");

        Student student = new Student();
        student.GetMessage("Ioannis", 34, 8000);

        Console.ReadLine();

    }
}