using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оператор_И_и_ИЛИ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Логическое И && 
            // x | y | x && y true = 1 false = 0 , так как взаимосвязан с bool, х умножаем на у
            // 1 | 1 | 5 == 5 && 3 != 4 true                 1
            // 1 | 0 | 5 != 4 && 3 == 2 false                0
            // 0 | 1 | 3 != 3 && 4 == 4 false                0
            // 0 | 0 | 1 == 2 && "hello" == "goodbuy" false  0

            // Логическое ИЛИ ||
            // x | y | x && y true = 1 false = 0 , так как взаимосвязан с bool, х умножаем на у
            // 1 | 1 | 'c' == 'c' || 1 == 1     true
            // 1 | 0 |  1 != 2 || 1 == 2        true
            // 0 | 1 | "gav" == "nya" || 4 == 4 true
            // 0 | 0 | 0 < -4 || 4 <= 3         false

            // пример с уровнем игрока и магазином

            int money = 500;
            int level = 10;

            if (money >= 500 || level >= 9) 
            {
                Console.WriteLine("Ты успешный бизнесмен!");
            }
            else
            {
                Console.WriteLine("Вы еще не можете быть бизнестренером");
            }

            int money2;
            int level2;

            Console.WriteLine("Сколько у вас денег?: ");
                money2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Какой у вас уровень?: ");
                level2 = Convert.ToInt32(Console.ReadLine());

            if (money2 == 300 && level2 == 30)
            {
                Console.WriteLine("У нас появился тракторист, верно?");
            }
            else if (money2 >= 250 && level2 >= 5)
            {
                Console.WriteLine("Задрот обнаружен!");
            }
            else
            {
                Console.WriteLine("Хитрый задрот");
            }


        }
    }
}
