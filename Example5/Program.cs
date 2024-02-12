namespace Example5;

class Program
{
    static void Main(string[] args)
    {
        bool status = false;

        bool result = status && GenerateStatus();

        Console.WriteLine($"Result {result}");
    }

    private static bool GenerateStatus()
    {
        Console.WriteLine("This statement is being evaluated!");
        return true;
    }
}