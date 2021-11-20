using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10cu_hefte_
{
    class Medicine
    {
        public string Name { get; set; }
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value > 0)
                {
                    Price = value;
                }
            }
            
        }
        public int Count {
            get
            {
                return Count;
            }
            set 
            {
                if (value >= 0)
                {
                    Count = value;
                }

            } 
        }
        public Medicine(string name,double price )
        {
            Name = name;
            Price = price;
            

        }
    }
    class Pharmacy
    {
        List<Medicine> product = new List<Medicine>();
        private double TotalIncome { get; set; }
        public void sell(string name,int count)
        {
            foreach (var item in product)
            {
                if (item.Name==name)
                {
                    count--;
                    TotalIncome += count * item.Price;
                }
                else
                {
                    Console.WriteLine("{0} adda derman yoxdur..",name); 
                }
            }

        }
        public Medicine FindMedicineByName(string name)
        {
            Medicine d=null;
            foreach (var item in product)
            {
                if (item.Name==name)
                {
                    d = item;
                }
                else
                {
                    Console.WriteLine("{0} adda derman yoxdur",name);
                }
            }
            return d;
        }
        

        }
    }



    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
