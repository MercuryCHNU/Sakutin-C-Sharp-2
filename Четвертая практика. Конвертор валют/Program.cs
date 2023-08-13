using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Четвертая_практика.Конвертор_валют
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float hrivnasInWallet;
            float dollarsInWallet;

            int hrnToUsd = 37, usdToHrn = 36;

            float exchangeCurrencyCount;

            string desiredOperation;

            Console.WriteLine("Добро пожаловать в Жужащий Банк! Рады вас приветствовать");
            Console.Write("Каков ваш баланс в гривнах?: ");
            hrivnasInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Каков ваш баланс в долларах?: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию: ");
            Console.WriteLine("1 - Купить доллары ");
            Console.WriteLine("2 - Купить гривны ");
            Console.Write("Ваш выбор: ");
            desiredOperation = Console.ReadLine();

            switch (desiredOperation)
            {
                case "1":
                    Console.Write("На какую сумму в гривнах вы хотите купить долларов?: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (hrivnasInWallet >= exchangeCurrencyCount)
                    {
                        Console.Write("Поздравляю! Вы купили доллары! ");
                        dollarsInWallet += exchangeCurrencyCount / hrnToUsd;
                        hrivnasInWallet -= exchangeCurrencyCount;
                    }
                    else
                    {
                        Console.WriteLine("Вы пытались купить больше валюты, нежели у вас было доступно на балансе");
                    }
                    break;
                case "2":
                    Console.Write("На какую сумму в долларах вы хотите купить гривны? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        Console.Write("Поздравляю! Вы купили гривны! ");
                        dollarsInWallet -= exchangeCurrencyCount;
                        hrivnasInWallet += exchangeCurrencyCount * usdToHrn;
                    }
                    else
                    {
                        Console.WriteLine("Вы пытались купить больше валюты, нежели у вас было доступно на балансе");
                    }
                    break;

                default: 
                    Console.WriteLine("Выбрана неверная операция");
                    break;

            }
            Console.WriteLine($"На вашем балансе находятся {hrivnasInWallet} гривен и {dollarsInWallet} долларов ");

        }
    }
}
