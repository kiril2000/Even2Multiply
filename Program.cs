using System;

namespace Even2Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
                n = n * 2;
            else
                Console.WriteLine("This is odd number!");

            Console.WriteLine(n);
        }
    }
}
