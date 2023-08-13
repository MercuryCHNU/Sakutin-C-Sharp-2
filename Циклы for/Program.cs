using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 4; i <= 10; i++) // i+=2 прибавляется по 2 === 2 4 6 8, можно делить, отнимать, умножать и т.д.{Console.WriteLine(i);}
            int age;
            Console.Write("Ваш возраст: ");

            age = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < age; i += 2)
            {
                if ( i == 0 )
                { continue; }

                Console.WriteLine($"Вам исполнилось {i} годиков!");
            }

        }
    }
}
