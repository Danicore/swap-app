using System;

namespace SwapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first number: ");
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter second number: ");
            b = int.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
