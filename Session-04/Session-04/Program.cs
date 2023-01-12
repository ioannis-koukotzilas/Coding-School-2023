using Session_04;

internal class Program {
    private static void Main(string[] args) {

        // Exercise One

        HelloName exerciseOne = new HelloName();

        Console.WriteLine(exerciseOne.GetMessageAndName());

        // Exercise Two

        SumDivision exerciseTwo = new SumDivision();

        Console.WriteLine(exerciseTwo.Calculate());

        // Exercise Three

        SpecifiedOperations exerciseThree = new SpecifiedOperations();

        Console.WriteLine(exerciseThree.OperationOne());
        Console.WriteLine(exerciseThree.OperationTwo());
        Console.WriteLine(exerciseThree.OperationThree());
        Console.WriteLine(exerciseThree.OperationFour());
        Console.WriteLine(exerciseThree.OperationFive());

        // Exercise Four

        AgeGender exerciseFour = new AgeGender();

        Console.WriteLine(exerciseFour.GetAgeGender());

        // Exercise Five

        SecondsConverter exerciseFive = new SecondsConverter();

        Console.WriteLine(exerciseFive.GetSeconds());

        // Exercise Six

        SecondsConverterRewrite exerciseSix = new SecondsConverterRewrite();

        Console.WriteLine(exerciseSix.GetSeconds());

        // Exercise Seven

        CelsiusConverter exerciseSeven = new CelsiusConverter();

        Console.WriteLine(exerciseSeven.GetDegrees());


        Console.ReadLine();

    }
}