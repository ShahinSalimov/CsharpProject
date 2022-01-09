using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konsoldan yaşınızı oxuyan və 10 ildən sonra yaşınızı çap edən proqram yazın .
            Console.WriteLine("zehmet olmazsa yashinizi daxil edin :");
            int yash = Convert.ToInt32(Console.ReadLine());
            find_age(yash);
            Console.ReadKey();
        }
        public static void find_age(int yash) 
        {
            int cari_tevellud = DateTime.Now.Year - yash;
            int cari_yash = DateTime.Now.Year - cari_tevellud;
            int on_il_sonra = cari_yash + 10;
            Console.WriteLine($"sizin hal hazirdaki yashiniz: {cari_yash} ;\n10 il sonraki yashiniz: {on_il_sonra}");
            
        
        }
    }
}
