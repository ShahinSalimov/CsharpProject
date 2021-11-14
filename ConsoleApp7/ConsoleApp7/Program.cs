using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Massivdə nece cüt və nece tək element var???
            int[] arr = new int[] { 2, 3, 4, 5, 6, 7, 8, 9,10,12,14 };
            int tek = 0;
            int cut = 0;
            foreach (var i in arr)
            {
                if (i % 2 == 0)
                {
                    cut++;
                }
                else if(i%2!=0)
                {
                    tek++;
                }
                else
                {
                    Console.WriteLine("eded sifira beraberdir");
                }
                

            }
            Console.WriteLine("tek ededlerin say {0}", tek);
            Console.WriteLine("cut ededlerin say {0}", cut);
            Console.ReadKey();
        }
                
    }
}
