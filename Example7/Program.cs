namespace Example7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age");
        int? a = Convert.ToInt16(Console.ReadLine());

        if (a < 50)
        {
            Console.WriteLine("You're still an underage");
        }
        else
        {
            Console.WriteLine("You're welcome!");
        }
    }
}