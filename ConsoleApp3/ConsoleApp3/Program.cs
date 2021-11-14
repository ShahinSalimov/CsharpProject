using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Massivin Uzunluğunu almaq üçün C# Proqramını yazın
            int[] ededler = new int[] { 2, 4, 6, 7, 8, 4, 3, 2, 3, 4 };
            int arrayuzunlug = ededler.Length;
            Console.WriteLine("massivin uzunlugu {0}-dir..", arrayuzunlug);
            Console.ReadKey();
        }
    }
}
