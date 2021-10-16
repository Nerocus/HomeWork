using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork2
{
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //объявление переменных и их значений
            string firstname = "Anna";
            string lastname = "Ivanova";
            int height = 160;

            int History = 4;
            int Math = 5;
            int RusLan = 3;

            int average_score = (Math + History + RusLan) / 3;

            //обычный вывод 
            WriteLine(firstname);
            WriteLine(lastname);
            WriteLine(height);
            WriteLine("average_score = {0}", average_score);
            WriteLine();

            //форматированный вывод
            WriteLine("Имя= {0}   Фамилия= {1}  Рост= {2}   Средний Бал ={3}", firstname, lastname, height, average_score);

            WriteLine();

            //Использование интерполяции строк
            WriteLine($"Имя= {firstname}   \nФамилия= {lastname} \nРост= {height} \nСредний бал= {average_score}");
            ReadKey();

            /*
             * 
            */
            

            var width= Console.WindowWidth;
            var Height = Console.WindowHeight;

            var center = width / 2; // выражаем центр экрана
            WriteLine("{0," + center + "}\n{1," + center + "}\n{2," + center + "}\n{3," + center + "}  ", firstname,lastname,height,average_score);

            ReadKey();


        }
       

    }
}
