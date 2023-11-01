using System;
namespace c
{
    class pro
    {
        public static void Main(String[] args)
        {

            int n, i = 0;
            Console.WriteLine("enter n value");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                i++;
                n = n / 10;
            }
            Console.WriteLine("Magnitude of given num is:" + i);
        }
    }
}