using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ввести два одномерных целочисленных массива A и B из N и M элементов
соответственно. Сформировать массив С, добавив в него сначала элементы
массива А, затем элементы массива B, кратные числу К.
 *
    Ввести одномерный целочисленный массив A. Сформировать массив B, записав в
него все элементы массива А, стоящие после минимального. Массив B
отсортировать по убыванию.*/
namespace ConsoleApp1
{
    class Program
    {
        static Random rand = new Random();

        static void Task1()
        {
            int n, m, k, count = 0;
            int[] A, B, C;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            A = new int[n];
            B = new int[m];
            for (int i = 0; i < n; i++)
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
            for (int i = 0; i < m; i++)
            {
                if (B[i] % k == 0)
                {
                    C[j] = B[i];
                    Console.Write($"{C[j]} ");
                    j++;
                }

            }
            Console.WriteLine();

        }
       static void Task2()
        {
            int n, min, pos=0;
            int[] A;
            n = Convert.ToInt32(Console.ReadLine());
            A = new int[n];
            min = A[0] = rand.Next(-10, 10);
            Console.Write($"{A[0]} ");
            for (int i = 1; i < n; i++)
            {
                A[i] = rand.Next(-10, 10);
                Console.Write($"{A[i]} ");
                if (A[i] < min)
                {
                    min = A[i];
                    pos = i;
                }     
            }
            Console.WriteLine();
            pos++;
            if(pos<n)
            {
                int[] B = new int[n - pos];
                for (int i = pos; i < n; i++) B[i - pos] = A[i];
                for(int i=0;i<(n-pos-1);i++)
                    for(int j=i+1;j<(n-pos);j++)
                    {
                        if(B[i]>B[j])
                        {
                            int buff = B[i];
                            B[i] = B[j];
                            B[j] = buff;
                        }
                    }
                for(int i=0;i<n-pos;i++) Console.Write($"{B[i]} ");
            }
        }
        static void Main(string[] args)
        {
            Task2();

            Console.ReadKey();
        }
    }
}
