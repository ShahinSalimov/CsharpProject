using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Massivdəki bütün mənfi elementləri çap etmək üçün C# proqramı yazın
            int[] arr = { -2, -34, -56, 3, 5, 6, 7, 8, 912, 34, -35, -98 };
            Console.WriteLine("butun menfi ededler:");
            foreach (var item in arr)
            {
                if (item<0)
                {
                    Console.Write(item);

                }

            }
            Console.ReadKey();
        }
    }
}
