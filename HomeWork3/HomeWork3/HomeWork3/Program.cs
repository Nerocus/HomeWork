using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1;
            string player2;
            int userTry;
            int level;
            int levelUp =4;
            Random randomizer = new Random();

            // Ввод Ников игроков 
            Console.WriteLine("Введите ник Игрока 1");
            player1 = Console.ReadLine(); 
            Console.WriteLine("Введите ник Игрока 2");
            player2 = Console.ReadLine();


            Console.WriteLine("Выберите уровень сложности \n1 Диапазон от 1 до 4 \n2 Диапазон от 1 до 5  \n3 Диапазон от 1 до 6 ");
            level = Convert.ToInt32(Console.ReadLine());
            if(level == 1)
            {
                levelUp = 4;
            }
            else if(level == 2)
            {
                levelUp = 5;
            }
            else if(level == 3)
            {
                levelUp = 6;
                
            }

            //Генерация и вывод случайного числа 
            int gameNumber = randomizer.Next(12,120);          
            Console.WriteLine($"Число = {gameNumber}");

            for (; gameNumber > 0 ; )
            {
                Console.WriteLine($"Ход игрока {player1}");
                userTry = Convert.ToInt32(Console.ReadLine());
                while ( userTry > levelUp || userTry <= 0)
                {
                    if (userTry > levelUp)
                    {
                        Console.WriteLine($"Число должно быть в диапазоне от 1 до {levelUp}. Попробуйте еще раз");
                        userTry = Convert.ToInt32(Console.ReadLine());
                    }
                    if (userTry <= 0)
                    {
                        Console.WriteLine($"Число должно быть в диапазоне от 1 до {levelUp}. Попробуйте еще раз");
                        userTry = Convert.ToInt32(Console.ReadLine());
                    }

                }

                gameNumber = gameNumber - userTry;
                if (gameNumber == 0)
                {
                    Console.WriteLine($"Победил Игрок: {player1}");
                }
                else
                {
                    Console.WriteLine($"Число = {gameNumber} ");
                }



                Console.WriteLine($"Ход игрока {player2}");
                userTry = Convert.ToInt32(Console.ReadLine());
                while (userTry > levelUp || userTry <= 0)
                {
                    if (userTry > levelUp)
                    {
                        Console.WriteLine($"Число должно быть в диапазоне от 1 до {levelUp}. Попробуйте еще раз");
                        userTry = Convert.ToInt32(Console.ReadLine());
                    }
                    if (userTry <= 0)
                    {
                        Console.WriteLine($"Число должно быть в диапазоне от 1 до {levelUp}. Попробуйте еще раз");
                        userTry = Convert.ToInt32(Console.ReadLine());
                    }

                }

                gameNumber = gameNumber - userTry;
                if (gameNumber == 0)
                {
                    Console.WriteLine($"Победил Игрок: {player2}");
                }
                else
                {
                    Console.WriteLine($"Число = {gameNumber} ");
                }
            }
            Console.WriteLine("The end");
            Console.ReadKey();
        }
    }
}
