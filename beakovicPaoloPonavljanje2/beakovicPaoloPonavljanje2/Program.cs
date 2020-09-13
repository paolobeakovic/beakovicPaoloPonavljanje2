using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaoloPonavljanje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunde;
            int minute;
            int sek;


            Console.WriteLine("Upiši sekunde");
            sekunde = Convert.ToInt32(Console.ReadLine());
            minute = sekunde / 60;
            sek = sekunde % 60;
            Console.WriteLine("{0} minuta i {1} sekundi", minute, sek);
            Console.ReadKey();


        }
    }
}