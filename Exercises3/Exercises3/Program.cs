using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konsolda cari tarix və vaxtı çap edən proqram yazın .
            int gun = DateTime.Now.Day;
            int ay = DateTime.Now.Month;
            int il= DateTime.Now.Year;
            int saat =DateTime.Now.Hour;
            int deqiqe =DateTime.Now.Minute;
            int saniye =DateTime.Now.Second;

            Console.WriteLine($"bugunki tarix: {gun}-{ay}-{il}\nSAAT: {saat}:{deqiqe}:{saniye}");
            Console.ReadKey();
        }
    }
}
