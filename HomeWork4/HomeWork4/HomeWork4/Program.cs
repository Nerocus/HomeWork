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
        {
            int[,] num1 = {
                { 1, 100000, 80000, 20000 },
                { 2, 120000, 90000, 30000 },
                { 3,80000,70000,    10000 },
                { 4,70000 , 70000 , 0},
                { 5 ,100000,80000 ,20000 },
                { 6,200000 ,120000,80000 },
                { 7, 130000 ,140000, -10000 },
                { 8,150000 ,65000,85000 },
                { 9 ,190000, 90000, 100000 },
                { 10 , 110000 , 70000 ,  40000},
                { 11 , 150000 , 120000 ,9000 },
                { 12,100000,80000,20000 }
            };
            int minValue1 = num1[0, 3];
            int minValue2 = num1[0, 3];
            int minValue3 = num1[0, 3];

            int minMonth1 = num1[0, 0];
            int minMonth2 = num1[0, 0];
            int minMonth3 = num1[0, 0];
            for (int i = 0; i < num1.GetLength(0); i++)
            {
                if (num1[i, 3] < minValue1)
                {
                    minValue3 = minValue2;
                    minMonth3 = num1[i, 0];

                    minValue2 = minValue1;
                    minMonth2 = num1[i, 0];

                    minValue1 = num1[i, 3];
                    minMonth1 = num1[i, 0];
                    
                    
                }
                else if (minValue2 > num1[i, 3])
                {
                    minValue3 = minValue2;
                    minMonth3 = num1[i, 0];

                    minValue2 = num1[i, 3];
                    minMonth2 = num1[i, 0];
                }
                else if (minValue3 > num1[i, 3])
                {
                    minValue3 = num1[i, 3];
                    minMonth3 = num1[i, 0];
                }
            }
            Console.WriteLine($"{minMonth1},{minValue1}");
            Console.WriteLine($"{minMonth2},{minValue2}");
            Console.WriteLine($"{minMonth3},{minValue3}");
            Console.ReadKey();
        }
    }
}
