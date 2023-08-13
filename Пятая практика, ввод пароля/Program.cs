using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пятая_практика__ввод_пароля
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 5;
            string password = "123456";
            string userInput;

            for (int i = 0; i < triesCount; i++)
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Как вы сумели разгадать пароль!? Здесь же спрятаны наши секреты!");
                    break;
                }
                else
                {
                    Console.WriteLine("Введен неправильный пароль");
                    Console.WriteLine($"У вас осталось {(triesCount - i - 1)} попыток");
                }
            }
        }
    }
}
