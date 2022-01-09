using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konsolda adınızı və soyadınızı çap edən konsol proqramı yazın .
            Console.WriteLine(fullname("Sahin", "Salimov"));
            Console.ReadKey();
            
        }
        public static string fullname(string ad,string soyad)
        {
            return $"sizin adiniz: {ad}\nsoyadiniz: {soyad}";

        }
    }
}
