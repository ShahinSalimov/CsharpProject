using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK13_kassa_aparati_
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashreg = new CashRegister();
            Console.WriteLine("zehmet olmazsa seciminizi edin : USD,EURO,TL");
            String valu = Console.ReadLine();
            Console.WriteLine("zehmet olmazsa mebleq daxil edin :");
            int mebl =Convert.ToInt32( Console.ReadLine());
            cashreg.AddSale(valu, mebl);
            Console.ReadKey();


        }
    }
}
