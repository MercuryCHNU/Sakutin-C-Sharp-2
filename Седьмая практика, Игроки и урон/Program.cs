using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Седьмая_практика__Игроки_и_урон
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHealth;
            int playerDamage;
            int enemyHealth;
            int enemyDamage;

            Console.WriteLine("Введите количество здоровья игрока: ");
            playerHealth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество урока игрока: ");
            playerDamage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество здоровья врага: ");
            enemyHealth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество урока врага: ");
            enemyDamage = Convert.ToInt32(Console.ReadLine());

            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine($"Здоровье игрока: {playerHealth}");
                Console.WriteLine($"Здоровье врага: {enemyHealth}");
            }

            if (playerHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья");
            }
            else if (playerHealth > 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Победа игрока!");
            }
            else if (playerHealth <= 0 && enemyHealth > 0)
            {
                Console.WriteLine("Победа врага!");
            }
        }
    }
}
