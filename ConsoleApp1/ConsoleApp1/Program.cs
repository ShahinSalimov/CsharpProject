using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //İstifadəçi tərəfindən daxil edilmiş tam ədədin tək və ya cüt olduğunu yoxlamaq üçün C# proqramı
            Console.WriteLine("zehmet olmazsa bir eded daxil edin : ");
            int eded = Convert.ToInt32(Console.ReadLine());
            if (eded % 2 == 0)
            {
                Console.WriteLine("daxil edilen eded cutdur..");
            }
            else
            {
                Console.WriteLine("daxil edilen eded tekdir..");

            }
            Console.ReadKey();
        }
    }
    
       

}
