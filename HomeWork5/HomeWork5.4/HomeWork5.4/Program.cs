using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._4
{
    class Program
    {
        static void Progression(string d)
        {
            int result = 0;
            string[] massiv = d.Split(' ');
            int[] progress = new int[massiv.Length];

            for (int i = 0; i < massiv.Length; i++)
            {
                progress[i] = Convert.ToInt32(massiv[i]);   
            }
            int b =progress[1]/progress[0]; // знаменатель геометрической прогрессии
            int a =progress[1]-progress[0]; // разность арифметической прогрессии

            int flags1 = 0;
            int flags2 = 0;

          //вычисление геометрической прогрессии
            for (int i = 0; i+1 < progress.Length ; i++)
            {
                   result = progress[i+1] / progress[i];
                    if (result != b)
                    {
                        flags1 = 1;
                        Console.WriteLine("Это не Геометрическая прогрессия");
                        break;
                    }
                
            }
            //вычисление арифметической прогрессии
            for (int i = 0; i+1 < progress.Length ; i++)
            {
                    result = progress[i+1] - progress[i];
                    if (result != a)
                    {
                        flags2 = 2;
                        Console.WriteLine("Это не Арифметическая прогрессия");
                        break;
                    }
            }


            
            if(flags1==1 && flags2==2)
            {
                Console.WriteLine("Это просто набор чисел");
            }
            else if (flags1 == 0)
            {
                Console.WriteLine("Геометрическая прогрессия");
            }
            else if (flags2 == 0)
            {
                Console.WriteLine("Арифметическая прогрессия");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Progression(s);
        }
    }
}
