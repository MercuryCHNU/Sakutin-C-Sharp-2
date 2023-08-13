using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Третья_практика_пароль
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "July2004";
            string userInput;

            Console.WriteLine("Введите пароль: ");

            userInput = Console.ReadLine();

            if (userInput == password)
            {
                Console.WriteLine("Поздравляю, пароль правильный!");
            }
            else
            {
                Console.WriteLine("Попробуйте заново");
            }
        }
    }
}
