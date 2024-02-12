namespace  Example1;

class  Program
{
    static void Main(string[] args)
    {
        int result = getValuePrefixValue();
        Console.WriteLine($"The value of a is { result }");
    }

    private static int getValuePrefixValue()
    {
        int a = 30;
        return --a;
    }

    private static int getValuePostFixValue()
    {
        int a = 30;
        return  a--;
    }
    
}