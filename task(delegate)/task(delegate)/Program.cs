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
            bool isdigit = b.Any(x => char.IsDigit(x));
            return isdigit;

        }
        /*
         GetValueIndexes() - string-ler ucun parameter oaraq gonderilen charin
        stringin hansi indexlerinde yerlesdiyini tapan ve 
        tapdigi butun indexleri array olaraq geri qaytaran metod 
        (hec bir deyer tapilmazsa geriya bos (0 uzunluqlu) int[] qayidir)
         */
        public static string GetValueIndexes(this string psw)
        {
           
            char[] a = psw.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                int change = Convert.ToInt32(a[i]);
                if (change>96 && change <123)
                {
                    Console.WriteLine(i+" stringdir");
                }
                else
                {
                    Console.WriteLine(i+" string deyil");
                }
                

            }
            return psw;
        }
        /*
         GetValueIndexes() - integer array-leri ucun parameter olaraq gonderilmis 
        integer deyerinin bu arrayin hansi indexlerinde oldugunu tapi ,
        butun tapdigi indexleri array olaraq geri qaytaran metod .
        (hec bir deyer tapilmazsa geriya bos (0 uzunluqlu) int[] qayidir)*/

        public static List<int> GetValueIndexes(this int[] b,int a)
        {
            List<int> c = new List<int>();
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i]==a)
                {
                    c.Add(i);
                }
                
            }
            return c;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            //int a = 10;
            //string b = "Baki32Kend";
            //string y = "baki";
            //char x = 'a';
            //string word = "azerbaycan123";

            //word.GetValueIndexes();
            int a = 12;
            int[] b = new int[] { 1, 3, 4, 5, 6, 12, 23 };
            foreach (var item in b.GetValueIndexes(a))
            {
                Console.WriteLine(a+" ededinin indexi "+item);
            }



            //bool result = a.IsOdd();
            //bool result1 = a.IsEven();
            //bool result2 = b.IsContainsDigit();

            //Console.WriteLine("eded tekdir? Netice : {0}", result);
            //Console.WriteLine("eded cutdur? Netice : {0}", result1);
            //Console.WriteLine("sozde reqem varmi? Netice : {0}", result2);
            Console.ReadKey();

        }


    }
}


