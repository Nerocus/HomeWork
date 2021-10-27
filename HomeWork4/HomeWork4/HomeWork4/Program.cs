using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int[,] num1 = {
                { 1, 100000, 80000, 20000 },
                { 2, 120000, 90000, 30000 },
                { 3,80000,70000,    1000 },
                { 4,70000 , 70000 , 100000},
                { 5 ,100000,80000 ,20000 },
                { 6,200000 ,120000,80000 },
                { 7, 130000 ,140000, 10000 },
                { 8,150000 ,65000,85000 },
                { 9 ,190000, 90000, 100000 },
                { 10 , 110000 , 70000 ,  40000},
                { 11 , 150000 , 120000 ,9000 },
                { 12,100000,80000,20000 }
            };
            int minProfit = 20000;
            int minValue = 0;
            int Month = 0;

            for (int i = 0; i < num1.GetLength(0); i++)
            {
                if (num1[i, 3] <= minProfit)
                {
                    Month = 
                    minValue = num1[i, 3];
                    Console.WriteLine($"{Month},{minValue}");
                }
            }
            Console.ReadKey();*/


            Console.Write("Введите количество строк : ");
            int n = int.Parse(Console.ReadLine());


            int[][] triangle = new int[n][];
            // первая строка
            triangle[0] = new int[] { 1 };

            for (int i = 1; i < triangle.Length; i++)
            {
                triangle[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        triangle[i][j] = 1;
                    else
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < triangle.Length; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write("{0,-3} ", triangle[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
