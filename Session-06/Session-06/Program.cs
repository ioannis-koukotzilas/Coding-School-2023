using Session_06;
using System.Xml.Linq;

internal class Program {
    private static void Main(string[] args) {

        Institute institute = new Institute();
        institute.GetMessage("Epsilon Net", 10);

        Person person = new Person();
        person.GetMessage("Petros", 29);

        Professor professor = new Professor();
        professor.GetMessage("Fotis", 45, "1");

        Student student = new Student();
        student.GetMessage("Ioannis", 34, 8000);

        Grade grade = new Grade();
        grade.GetMessage(17);

        Course course = new Course();
        course.GetMessage("Session-06", "C# Classes, Properties, Constructors, Methods");

        Console.ReadLine();

    }
}