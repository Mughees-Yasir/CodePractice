using System;
namespace Factor
{
    class Program
    {
        public static void Main()
        {
            int i = 2, n;
            Console.WriteLine("Enter a value");
            n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                if (n < 10 && i <= n)
                {
                    Console.WriteLine(n + "Dont have any single digit factor other then one");
                    break;
                }

                if (n % i == 0)
                {
                    Console.WriteLine(i + "is smallest factor");
                    break;
                }

                i++;

            }
            Console.ReadKey();
        }
    }
}