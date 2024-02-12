namespace Example3;

class Program
{
    static void Main(string[] args)
    {
        int x = 20;
        int y = 80;
        long z = 1000;

        bool result1 = x < y;
        bool result2 = y > z;
        bool result3 = z >= x;

        Console.WriteLine($"Result 1 {result1}");
        Console.WriteLine($"Result 2 {result2}");
        Console.WriteLine($"Result 3 {result3}");
    }
}