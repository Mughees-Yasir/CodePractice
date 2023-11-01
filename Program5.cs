using System;
namespace Application
{
    class Program
    {
        public static void Main(String[] args)
        {
            int num, nextdigit, numdigits;
            int[] n = new int[20];
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number" + num);
            Console.WriteLine("number in words");
            nextdigit = 0;
            numdigits = 0;
            do
            {
                nextdigit = num % 10;
                n[numdigits] = nextdigit;
                numdigits++;
                num = num / 10;
            } while (num > 0);
            numdigits--;
            for (; numdigits >= 0; numdigits--)
                Console.WriteLine(digits[n[numdigits]] + " ");
            Console.ReadLine();
        }
    }
}