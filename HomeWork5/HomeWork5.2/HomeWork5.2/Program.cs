using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._2
{
    class Program
    {
        // Задание 2.1
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// нвхождение минимальных слов в тексте
        static void MinWords(string d)
        {
            
            string[] massiv = d.Split(' ', ',', '.');
            int[] kolStrok = new int[massiv.Length];

            for (int i = 0; i < massiv.Length; i++)
            {
                kolStrok[i] = massiv[i].Length;
            }

            var min = kolStrok.Min();
            for (int i = 0; i < kolStrok.Length; i++)
            {
                if (min == kolStrok[i])
                {
                    Console.WriteLine(massiv[i]);
                }
            }
            Console.ReadKey();
        }
        // Задание 2.2
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// нвхождение максимального(ых) слов в тексте
        static void MaxWords(string d)
        {
            
            string[] massiv = d.Split(' ',',','.');
            int[] kolStrok = new int[massiv.Length];

            for (int i = 0; i < massiv.Length; i++)
            {
                kolStrok[i] = massiv[i].Length;
            }

            var min = kolStrok.Max();
            for (int i = 0; i < kolStrok.Length; i++)
            {
                if (min == kolStrok[i])
                {
                    Console.WriteLine(massiv[i]);
                }
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
           string s = Console.ReadLine();
           MinWords(s);
           MaxWords(s);
        }
    }
}
