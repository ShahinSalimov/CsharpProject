using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zehmet olmasa valyuta daxil edin ( USD,EURO,TL): ");
            string value = Console.ReadLine();
            Console.WriteLine("zehmet olmasa meblegi daxil edin: ");
            double mebleq = Convert.ToDouble(Console.ReadLine());

            Valuex.Exchange(value, mebleq);
            Console.ReadKey();



        }

    }
}
    
