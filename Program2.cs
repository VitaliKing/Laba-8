using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            if (n == 0 || m == 0)
            {
                Console.WriteLine("Задан пустой массив");
                Console.ReadKey();
                return;
            }
            int[,] A = new int[n, m];
            int[] sum = new int[n];
            Random R = new Random();
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int g = 0; g < m; g++)
                {
                    A[i, g] = R.Next(0, 21);
                    Console.Write("{0}\t", A[i, g]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i< n; i++)
            {
                int max = 0;
                for (int g= 0; g< m; g++)
                {
                    if (A[i, g] > max)
                    {
                        max = A[i, g];
                    }
                }
                sum[i] = max;
            }
            Console.WriteLine("Одномерный массив из максимальных элементов строк");
            for(int i = 0; i < n; i++)
            {
                Console.Write("{0}\t",sum[i]);
            }
            Console.ReadKey();
        }
    }
}
