using System;
namespace matrix
{
    class Prol
    {

        public static void Main(String[] args)
        {
            int i, j, m, n, p, q, k;
            int[,] a = new int[30, 30];
            int[,] b = new int[30, 30];
            int[,] c = new int[30, 30];
            Console.WriteLine("enter rows and colums of first matrix");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rows and colums of second matrix");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elemnts of first matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                    a[i, j] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < p; i++)
                for (j = 0; j < q; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                    if ((m == p) && (n == q))
                    {
                        Console.WriteLine("addition is possible");
                        for (i = 0; i < m; i++)
                            for (j = 0; j < n; j++)
                                c[i, j] = a[i, j] + b[i, j];
                        for (i = 0; i < m; i++)
                            for (j = 0; j < n; j++)
                                Console.WriteLine(c[i, j] + "/t");
                        Console.WriteLine("/n");
                    }
                    else
                        Console.WriteLine("addition is not possible");
                    if (n != p)
                        Console.WriteLine("Mul is not possible");
                    else
                    {
                        for (i = 0; i < m; i++)
                            for (j = 0; j < n; j++)
                            {
                                c[i, j] = 0;
                                for (k = 0; k < m && k < q; k++)
                                    c[i, j] = c[i, j] + a[i, k] * b[k, j];
                            }
                        Console.WriteLine("The matrix is");
                        for (i = 0; i < m; i++)
                            for (j = 0; j < n; j++)
                                Console.WriteLine("\t" + c[i, j]);
                        Console.WriteLine("\n");
                    }
                }
        }
    }
}