using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Telebe telebe1 = new Telebe
            {
                Id = 1,
                name = "Nazim",
                surname = "Memmedov"
            }; Telebe telebe2 = new Telebe
            {
                Id = 2,
                name = "Nadir",
                surname = "ezimov"
            }; 

            Console.WriteLine("1ci telebenin ID-si {0}",telebe1.Id);
            Console.WriteLine("1ci telebenin ADI-si {0}",telebe1.name);
            Console.WriteLine("1ci telebenin SOYADI {0}",telebe1.surname);
            Console.WriteLine("=================================================");
            Console.WriteLine("2ci telebenin ID-si {0}",telebe2.Id);
            Console.WriteLine("2ci telebenin ADI-si {0} {0}", telebe2.name);
            Console.WriteLine("2ci telebenin SOYADI {0}", telebe2.surname);
            Console.ReadKey();
        }
    }
    class Telebe
    {
        public int Id;
        public string name;
        public string surname;
    }
}
