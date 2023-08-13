using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оператор_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int minAge = 18;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            if ( age >= minAge)
            {
                Console.WriteLine("Добро пожаловать в наш клуб! Вы сумели пройти проверку на возраст!");
                Console.WriteLine("Теперь, жду от вас выполнение заданий, которые были вам даны");
            }
            else // Эта ветвь не обязательна
            {
                Console.WriteLine("Вы еще не совершеннолетный, юноша! Доступ запрещен.");
                Console.WriteLine("Приходите к нам через: " + (minAge - age) + " Лет");
            }

            Console.WriteLine("На этом все");
            Console.WriteLine("");

            string dayOfWeek;
            Console.WriteLine("Введите день недели: ");
            dayOfWeek = Console.ReadLine();

            if (dayOfWeek == "Понедельник")
            {
                Console.WriteLine("Сегодня мы практикуемся");
            }
            if (dayOfWeek == "Вторник") // если нужно несколько независимых элементов, которые будут проверятся независимо он первого if.
            {
                Console.WriteLine("Сегодня мы делаем домашнее задание");
            }
            else if (dayOfWeek == "Среда")
            {
                Console.WriteLine("Сегодня мы отдыхаем");
            }
            else
            {
                Console.WriteLine("Ничего не найдено");
            }


        }
    }
}
