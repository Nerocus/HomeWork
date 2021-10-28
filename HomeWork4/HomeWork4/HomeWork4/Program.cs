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

            int[] income = new int[12];// Доход
            int[] spending = new int[12];//Расход
         
            Random rand = new Random();//Рандомное заполнение массива дохода
            for (int i = 0; i < 12; i++)
            {
                income[i] = rand.Next(0, 3);
              //  int result1 = income[i] % 1000 >= 500 ? income[i] + 1000 - income[i] % 1000 : income[i] - income[i] % 1000;
                Console.WriteLine($"{income[i]}");
            }

            Console.WriteLine();

            
            for (int i = 0; i < 12; i++)//Рандомное заполнение массива расхода
            {
                
                spending[i] = rand.Next(0, 3);
              //  int result2 = spending[i] % 1000 >= 500 ? spending[i] + 1000 - spending[i] % 1000 : spending[i] - spending[i] % 1000;
                Console.WriteLine($"\t{spending[i]}");
            }


            int[] profit = new int[12];
            for (int i = 0; i < profit.Length; i++) //Расчет прибыли
             {
                    profit[i] = income[i] - spending[i];
                    // int result3 = profit[i] % 1000 >= 500 ? profit[i] + 1000 - profit[i] % 1000 : profit[i] - profit[i] % 1000;
                    Console.WriteLine($"\t\t{profit[i]}");
             }

            int[] minValue = new int[12];
            for (int i = 0; i < profit.Length; i++)
            {
                Array.Copy(profit, minValue, profit.Length);
                    
               }
            //Нахождение трёх минимальных значений массива
            Array.Sort(minValue);
            var min1 = minValue[0];
            var min2 = minValue[1];
            var min3 = minValue[2];
            Console.WriteLine($"{min1},{min2},{min3}");
            int month = 0;

            for (int i = 0; i < profit.Length; i++)// Поиск  одинаковой прибыли по месяцам
            {
                if (profit[i] == min1 || profit[i] == min2 || profit[i] == min3)
                {
                    month = i;
                    Console.WriteLine($"Месяц с минимальной прибылью: {month}\tПрибыль составила:{profit[i]}");
                }
            }
            Console.ReadKey();
            //for (int i = 0; i < num1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < num2.GetLength(0); j++)
            //    {

            //    }
            //}

            //if (num1[i, 3] <= minProfit)
            //{
            //    Month =
            //    minValue = num1[i, 3];
            //    Console.WriteLine($"{Month},{minValue}");
            //}

            /*
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

            Console.ReadKey();*/
        }
    }
}
