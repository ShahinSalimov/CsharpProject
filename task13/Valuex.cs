using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    public static class Valuex
    {
        public static void Exchange(string curtype,double mebleq)
        {
            Dictionary<string, double> cureen = new Dictionary<string, double>();
            cureen.Add(curtype, mebleq);
            foreach (var item in cureen)
            {
                if (item.Key==CurrencyType.EURO.ToString())
                {
                    Console.WriteLine(mebleq*2);
                }
                else if (item.Key == CurrencyType.USD.ToString())
                {
                    Console.WriteLine(mebleq * 1.7);

                }
                else if(item.Key == CurrencyType.TL.ToString())
                {
                    Console.WriteLine(mebleq * 0.3);

                }
                else
                {
                    Console.WriteLine("duzgun valyuta daxil edilmedi..");
                }

            }
        }
        

    }
    public enum CurrencyType
    {
        USD,
        EURO,
        TL
    }
}

