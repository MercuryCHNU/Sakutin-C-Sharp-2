using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Сколько вам лет?: ");
            age = Convert.ToInt32(Console.ReadLine());

            while (age-- > 0) // если не указывать --, тогда цыкл будет вечным, а так, будет ровно столько, сколько указан возраст
            {
                // Console.WriteLine("А тепер, нужно переделать первую практику! Йо-хо-хо");
                // or age-- here;

                // if (age == 5) { break; } // отнимает от цыкла 5 строчек

                if (age == 8) { continue; } // пропускает ту строку или строки, которые указаны в условии

                Console.WriteLine(age);
            }

        }
    }
}
