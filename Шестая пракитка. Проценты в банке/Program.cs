using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шестая_пракитка.Проценты_в_банке
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money;
            int years;
            int percent;
            int percentYear = 100;

            Console.Write("Введите количество денег, которые желаете внести на счет: ");
            money = Convert.ToSingle(Console.ReadLine());

            Console.Write("На какой строк вы хотите оформить депозит? ");
            years = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какой процент вы хотите? ");
            percent = Convert.ToInt32(Console.ReadLine());

            for ( int i = 0; i < years; i++ ) // int i = 1; i <= years
            {
                money += money * percent / percentYear;
                Console.WriteLine($"В этом коду у вас на счету {money} денег! Мои поздравления");
                Console.ReadKey();
            }
        }
    }
}
