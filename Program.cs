using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, слово или текст: ");
            string text = Console.ReadLine();
            text = System.Text.RegularExpressions.Regex.Replace(text, @"\s+", "");              
            char[] obrattext = text.ToCharArray();
            Array.Reverse(obrattext);
            string resulttext = new string(obrattext);
            if (text == resulttext)
                Console.WriteLine("Введённая запись - палиндром");
            else
                Console.WriteLine("Введённая запись - не палиндром");
            Console.ReadKey();
        }
    }
}
