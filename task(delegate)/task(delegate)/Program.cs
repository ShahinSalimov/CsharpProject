using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_ExtentionMethods1_
{

    public static class ExtentionMethods
    {
        //IsOdd() - int obyektler ucun hemin obyektin tek eded olub olmadigini geri qaytaran
        //(true/false) method
        public static bool IsOdd(this int a)
        {

            return a % 2 != 0;
        }
        //IsEven() - int obyektler ucun hemin obyektin cut eded olub olmadigini geri qaytaran
        //(true/false) method
        public static bool IsEven(this int a)
        {

            return a % 2 == 0;
        }
        //IsContainsDigit() - string obyektler ucun hemin obyektin daxilinde digit charactre
        //olub olmamsini geri qaytaran(true/false) metod
        //public bool IsContainsDigit(string a)
        public static bool IsContainsDigit(this string b)
        {
            bool isdigit=b.Any(x => char.IsDigit(x));
            return isdigit;

        }

        class Program
        {
            static void Main(string[] args)
            {

                int a = 10;
                string b = "Baki32Kend";

                bool result = a.IsOdd();
                bool result1 = a.IsEven();
                bool result2 = b.IsContainsDigit();

                Console.WriteLine("eded tekdir? Netice : {0}", result);
                Console.WriteLine("eded cutdur? Netice : {0}", result1);
                Console.WriteLine("sozde reqem varmi? Netice : {0}", result2);

                Console.ReadKey();
            }


        }
    }
}

