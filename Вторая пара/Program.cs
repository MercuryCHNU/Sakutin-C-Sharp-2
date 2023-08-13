using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вторая_практика._Магазин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;
            Console.WriteLine($"Добро пожаловать в наш магазин! Сегодня цена на молочную продукцию становит около {foodUnitPrice} гривен!");

            Console.Write("Каков ваш баланс в гривнах? ");
            money = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Ваш баланс равен {money} гривен");

            Console.Write("Сколько вы хотите купить молочки в штуках? ");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodUnitPrice;

            Console.WriteLine($"Ваше количество молочки равно {food} единиц, и ваш остаток равен {money} гривен");
            Console.WriteLine("Спасибо за покупку!");
        }
    }
}
