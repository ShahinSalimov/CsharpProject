using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Minimum və maksimum ədədləri tapmaq üçün C# proqramı yazın
            int[] ededler = {23,-56,-45,25,785,90,456,345,-456};
            Console.WriteLine("Maximum eded {0}-dir",ededler.Max());
            Console.WriteLine("Minimum eded {0}-dir",ededler.Min());
            Console.Read();

        }


    }
}
