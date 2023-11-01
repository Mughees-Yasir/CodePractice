using System;
//using System.Collection.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    class B
    {

        public static void Main(String[] args)
        {
            string[,] a = new String[10, 10];
            char[] x = new Char[10];
            int[] t = new int[10];
            string[] g = new String[10];
            string b;
            Console.WriteLine("enter rows");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coloumns");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    a[i, j] = Console.ReadLine();
            }
            int k = 0, c = 0, s = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b = a[i, j];
                    c = 0;
                    for (k = 0; k < b.Length; k++)
                    {
                        if (b[k] == 'a')
                            c++;
                        else if (b[k] == 'e')
                            c++;
                        else if (b[k] == '1')
                            c++;
                        else if (b[k] == '0')
                            c++;
                        else if (b[k] == 'u')
                            c++;
                    }
                    g[s] = b;
                    t[s] = c;
                    s++;
                }
            }
            int temp;
            string tem;
            for (int j = 0; j < s; j++)
            {
                for (int i = 0; i < s; i++)
                {
                    if (t[i] >= t[j])
                    {
                        temp = t[i];
                        t[i] = t[j];
                        t[j] = temp;
                        tem = g[i];
                        g[i] = g[j];
                        g[j] = tem;
                    }
                    Console.WriteLine("strings having more numbers of vowels are\n");
                    for (int l = 0; i < s; i++)
                    {
                        if (t[i] <= t[s - 1])
                            Console.WriteLine(g[i]);
                    }
                    Console.WriteLine("word has " + t[s - 1] + "vowels");
                    Console.ReadKey();
                }
            }
        }
    }
}