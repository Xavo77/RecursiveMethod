using System;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of a method recursive");
            Console.WriteLine("***********************************");
            Console.WriteLine("Introduce one number: ");
            string n = Console.ReadLine();
            Console.WriteLine(MethodRecursive(int.Parse(n)));
            Console.ReadLine();
        }

        // Example of recursive method. Get the factorial
        static decimal MethodRecursive(int num)
        {
            if (num <= 0 )
            {
                return 1;
            }
            return num * MethodRecursive(num - 1);
        }
    }
}