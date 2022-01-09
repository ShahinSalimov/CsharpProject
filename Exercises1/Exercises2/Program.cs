using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1, 101, 1001 konsolunda hər biri yeni sətirdə cəmi
            //10 ədədə qədər aşağıdakı rəqəmləri çap edən proqram yazın . 
            string s = "2";
            Console.WriteLine(s);
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine(s.PadRight(i, '1') + "2");
            }
            Console.ReadKey();
        }
    }
}
