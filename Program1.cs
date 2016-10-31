using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            if (n == 0 || m ==0)
            {
                Console.WriteLine("Задан пустой массив");
                Console.ReadKey();
                return;
            }
            int[,] A = new int[n,m];
            Random R = new Random();
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int g = 0; g < m; g++)
                {
                    A[i,g] = R.Next(10, 101);
                    Console.Write("{0}\t", A[i,g]);
                }
                Console.WriteLine();
            }
            int max = 0;
            int ind = 0;
            int sum = 0;
            for (int i = 0; i<n; i++)
            {
                for (int g = 0; g<m; g++)
                {
                    sum += A[i, g];
                }
                if (max < sum)
                {
                    max = sum;
                    ind = i;
                }
                Console.WriteLine("Сумма в {0} строке = {1}", i+1, sum);
                sum = 0;
            }
            Console.WriteLine("Максимальная сумма элементов в строке {0}", ind+1);
            Console.ReadKey();
        }
    }
}
