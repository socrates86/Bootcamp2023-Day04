namespace Example6;

class Program
{
    static void Main(string[] args)
    {
        bool status = true;

        bool result = status || GenerateStatus();
        Console.WriteLine($"Result {result}");
    }

    private static bool GenerateStatus()
    {
        Console.WriteLine("This statement has been evaluated!");
        return true;
    }
}