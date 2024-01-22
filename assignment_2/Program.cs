namespace assignment_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, my name is Mostafa");
        
        CountTo(5);
    }
 
    static void CountTo(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}

