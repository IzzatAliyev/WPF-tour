namespace PractWork1Console;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            System.Console.WriteLine(
                """
            Welcome to console app for calculating 2c+d math expression;
            Author: Aliyev Izzat, ASTSI-20-1

            """);

            System.Console.Write("Enter value for c: ");
            var valueC = float.TryParse(System.Console.ReadLine(), out var valueOfC) ? valueOfC : throw new Exception("Variable c is not a number !!!");
            System.Console.Write("Enter value for d: ");
            var valueD = float.TryParse(System.Console.ReadLine(), out var valueOfD) ? valueOfD : throw new Exception("Variable d is not a number !!!");

            System.Console.WriteLine(
                """
                (1) Execute;
                (0) Exit;
                """);
            var option = int.TryParse(System.Console.ReadLine(), out var optionValue) ? optionValue : throw new Exception("must be numeric!!!");
            switch(option){
                case 1: CalculateExpression(valueC, valueD); break;
                case 0: CloseApp(); break;
                default: System.Console.WriteLine("Option must be 0 or 1"); break;
            }
            
            var sum = 2 * valueC + valueD;
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }

    private static void CalculateExpression(float valueC, float valueD)
    {
        var sum = 2 * valueC + valueD;
        System.Console.WriteLine($"The result is {sum}");
        CloseApp();
    }

    private static void CloseApp()
    {
        System.Environment.Exit(0);
    }
}