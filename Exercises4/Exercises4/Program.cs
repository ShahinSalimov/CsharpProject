using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            //2, -3, 4, -5, 6, -7, 8 ardıcıllığının ilk 100 üzvünü çap edən proqram yazın .
            for (int i = 2; i <100; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine("-"+i);

                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
