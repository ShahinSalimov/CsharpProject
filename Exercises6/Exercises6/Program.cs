using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises6
{
    class Program
    {
        public static Action<sbyte> Print { get; private set; }

        static void Main(string[] args)
        {
            //Hər biri üçün sbyte , byte , short , ushort , int , uint , long və ulong
            //növlərindən ən uyğununu seçərək bir neçə dəyişən elan edin ki ,
            //onlara aşağıdakı dəyərləri təyin edin: 52,130; -115; 4825932; 97; -10000;
            //20000; 224; 970,700,000; 112; -44; -1 000 000; 1990; 123456789123456789
            List<double> find = new List<double>();
            find.Add(-52130);
            find.Add(-115);
            find.Add(4825932);
            find.Add(97);
            find.Add(-10000);
            find.Add(-20000);
            find.Add(97070000);
            find.Add(112);
            find.Add(-44);
            find.Add(-1000000);
            find.Add(1990);
            find.Add(123456789123456789);
            
            List<double> sbyte_olanlar=new List<double>();
            List<double> byte_olanlar = new List<double>();
            List<double> short_olanlar = new List<double>();
            List<double> ushort_olanlar = new List<double>();
            List<double> int_olanlar = new List<double>();
            List<double> uint_olanlar = new List<double>();
            List<double> long_olanlar = new List<double>();
            List<double> ulong_olanlar = new List<double>();
            foreach (var item in find)
            {
                if (item ==byte.MaxValue || item>=byte.MinValue)
                {
                    byte_olanlar.Add(item);
                }
                else if (item <= sbyte.MaxValue || item >= sbyte.MinValue)
                {
                    sbyte_olanlar.Add(item);
                }
                else if (item < ushort.MaxValue || item > ushort.MinValue)
                {
                    ushort_olanlar.Add(item);
                }
                else if (item < short.MaxValue || item > short.MinValue)
                {
                    short_olanlar.Add(item);
                }
                else if (item < int.MaxValue || item > int.MinValue)
                {
                    int_olanlar.Add(item);
                }
                else if (item < uint.MaxValue || item > uint.MinValue)
                {
                    uint_olanlar.Add(item);
                }
                else if (item < long.MaxValue || item > long.MinValue)
                {
                    long_olanlar.Add(item);
                }
                else if (item < ulong.MaxValue || item > ulong.MinValue)
                {
                    ulong_olanlar.Add(item);
                }
                
            }
            show(find);
            show(ulong_olanlar);
            show(long_olanlar);
            show(uint_olanlar);
            show(int_olanlar);
            show(sbyte_olanlar);
            show(byte_olanlar);
            show(ushort_olanlar);
            show(short_olanlar);
            Console.ReadKey();


        }
        public static void show(List<double> paz) 
        {
            foreach (var item in paz)
            {
                Console.WriteLine(item);
            }
        }
        
        }
    }


