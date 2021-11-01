using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._3
{
    class Program
    {       //задание 3
        static void Сleaner(string d)
        {
           
            string[] massiv = d.Split(' ', ',', '.');          

            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = new string(massiv[i].Distinct().ToArray());
            }
            
               Console.WriteLine( string.Join(" ", massiv));
                
           


            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Сleaner(s);
            Console.ReadKey();
        }
    }
}
