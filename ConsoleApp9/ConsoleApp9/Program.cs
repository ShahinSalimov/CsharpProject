using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Massivin bütün elementlərinin cəmini tapmaq üçün C# proqramı yazın
            int[] ededler = {1,2,3,4,5,6,7,8,9 };
            int sum = 0;
            foreach (var i in ededler)
            {
                sum += i;

            }
            Console.WriteLine("massivdeki ededlerin cemi {0}-e beraberdir....", sum);
            Console.ReadKey();
        }
    }
}
