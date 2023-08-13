using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek;
            Console.WriteLine("Введите день недели: ");
            dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "Понедельник":
                case "Суббота":
                    Console.WriteLine("Нужно учить c#");
                    Console.WriteLine("И меньше лежать");
                    break;
                case "Вторник":
                    Console.WriteLine("Незабывать о программе на август");
                    Console.WriteLine("И усердно тренироваться");
                    break;
                case "Среда":
                case "Воскресенье":
                    Console.WriteLine("Сегодня можно отдохнуть");
                    Console.WriteLine("И подучить гуманитарные науки");
                    break;
                case "Четверг":
                    Console.WriteLine("Учиться, сэр");
                    Console.WriteLine("И сделать тесты");
                    break;
                case "Пятница":
                    Console.WriteLine("Много гуманитарных наук");
                    Console.WriteLine("И практики");
                    break;
                default:
                    Console.WriteLine("Ошибка 404. Неправильный день недели");
                    break;
            }













            if (dayOfWeek == "Понедельник" || dayOfWeek == "Суббота")
            {
            }
            else if (dayOfWeek == "Вторник") // если нужно несколько независимых элементов, которые будут проверятся независимо он первого if.
            {
            }
            else if (dayOfWeek == "Среда" || dayOfWeek == "Воскресенье")
            {
            }
            else
            {
            }
        }
    }
}
