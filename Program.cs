namespace _Net_Fun;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Press any key to exit.");

        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            count++;
            Console.WriteLine($"Count is {count} in loop iteration {i+1}");
        }
        
    }
}
