using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Üç ədəd arasında ən böyük ədədi tapmaq üçün C# proqramı.
            Console.WriteLine("1ci ededi daxil edin: ");
            int eded1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2ci ededi daxil edin: ");
            int eded2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3ci ededi daxil edin: ");
            int eded3 = Convert.ToInt32(Console.ReadLine());
            if (eded1 > eded2 && eded2>eded3)
            {
                Console.WriteLine("{0} ededi daha boyukdur...", eded1);
            }
            else if(eded2>eded1 && eded3 < eded1)
            {
                Console.WriteLine("{0} ededi daha boyukdur...", eded2);

            }
            else
            {
                Console.WriteLine("{0} ededi daha boyukdur...", eded3);

            }
            Console.ReadKey();


        }
    }
}
