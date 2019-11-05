using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ввести два одномерных целочисленных массива A и B из N и M элементов
соответственно. Сформировать массив С, добавив в него сначала элементы
массива А, затем элементы массива B, кратные числу К.

    Ввести одномерный целочисленный массив A. Сформировать массив B, записав в
него все элементы массива А, стоящие после минимального. Массив B
отсортировать по убыванию.*/
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int n, m, k,count=0;
            int[] A,B,C;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            A = new int[n];
            B = new int[m];
            for(int i=0;i<n;i++)
            {
                A[i] = rand.Next(-10, 10);
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                B[i] = rand.Next(-10, 10);
                if (B[i] % k == 0) count++;
                Console.Write($"{B[i]} ");
            }
            Console.WriteLine();
            C = new int[n + count];
            for (int i = 0; i < n; i++)
            {
                C[i] = A[i];
                Console.Write($"{C[i]} ");
            }
                int j = n;
            for(int i=0;i<m;i++)
            {
                if (B[i] % k == 0)
                {
                    C[j] = B[i];                    
                    Console.Write($"{C[j]} ");
                    j++;
                }
                
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
