using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рамерность массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int num = 0;
            int smax = 0;
            int[,] mas = new int[n, m];
            Random ran = new Random();
            Console.WriteLine("Данный массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = ran.Next(10, 100);
                    Console.Write("{0}\t", mas[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                int max = 0;

                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                    }
                }
            }
            for (int i = 0; i < sum.Length; i++)
            {
                if (sum[i] > smax)
                {
                    smax = sum[i];
                    num = i + 1;
                }
            }
            Console.WriteLine("Максимальная сумма в строке=" + smax);
            Console.WriteLine("Номер строки = " + num);
            Console.ReadKey();
        }
    }
}
