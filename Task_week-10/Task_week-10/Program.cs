using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Medicine
{
    //1.CI ETAP :Aşağıdakı member-leri olan Medicine (derman) classi yaradirsiniz
    //>Name - dermanin adi,Price - dermanin qiymeti,Count - dermanin sayi
    //Medicine obyektinin adi ve qiymeti yaradildigi an teyin olunmalidir.
    //Adsiz ve ya qiymetsiz medicine obyekti ola bilmez.
    //Qeyd: Dermanin qiymeti 0-dan boyuk olmalidir.Dermanin sayi 0-dan az ola bilmez.

    class Medicine
    {
        public string Name { get; set; }
        public double Price { 
            get 
            {
                return Price;
            } 
            set 
            {
                if (value>0)
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
        public Medicine(double price,string name)
        {
            Name = name;
            Price = price;
        }
    }
    //2.CI ETAP :Aşağıdakı memberlerden ibaret Pharmacy (aptek) class-i yaradirsiniz
    //Medicines - aptekdeki dermanlar siyahisini ifade edir (Medicine array-i)
    //>TotalIncome - derman satislarindan elde edilen gelir.
    //Bu memberin deyeri yalnizca satislar zamani artmalidir.
    //Basqa hec bir sekilde deyisdirile bilinmemelidir.
    //>Sell() - bu metod derman satisi ifade edir.Parameter olaraq dermanin adi ve sayini qebul edir.
    //Hemin ada gore sihayidan axtarib tapacagi dermanin satisini heyata kecirir.
    //>FindMedicineByName() - bu metod adina gore axtarilan derman obyektini geri qaytarir.
    //Parameter olaraq axtarilan dermanin adini qebul edir.
    //Hemin ad ile dermanlar sihayisindan axtaris edib eyni adli derman obyektini tapıb
    //geri qaytarir.
    //>AddMedicine() - bu metod dermanlar siyahisina yeni derman elave etmeyi ifade edir.
    //Parameter olaraq medicine qebul edir.
    //Qeyd : aptekin dermanlar siyahisinda eyni adda yalnizca bir medicine obyekti ola biler.
    //İkinci eyin adli medicine obyekti elave edile bilmez
    class Pharmacy
    {
        List<Medicine> product = new List<Medicine>();


        private double TotalIncome { get; set; }
        public void Sell(string name, int count)
        {
            foreach (var item in product)
            {
                if (item.Name == name)
                {
                    count--;
                    TotalIncome += count * item.Price;
                }
                else
                {
                    Console.WriteLine("{0} adda derman yoxdur..", name);
                }
            }
        }
        public Medicine FindMedicineByName(string name)
        {
            Medicine d = null;
            foreach (var item in product)
            {
                if (item.Name == name)
                {
                    d = item;
                }
                else
                {
                    Console.WriteLine("{0} adda derman yoxdur", name);
                }
            }
            return d;
        }
        public void AddMedicine(Medicine  prdct)
        {
            
            foreach (var item in product)
            {
                if (item.Name == prdct.Name)
                {
                    item.Count += prdct.Count;
                }
                else
                {
                    product.Add(prdct);
                }

            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Medicine derman1 = new Medicine(5.80,"Ketanol");
            Medicine derman2 = new Medicine(0.80, "nimesil");
            Medicine derman3 = new Medicine(6.60, "Tirazol");
           

            Pharmacy aptek = new Pharmacy();
            aptek.Sell("Tirazol", 1);
            aptek.Sell("nimesil", 1);
            aptek.FindMedicineByName("nimesil");
            
            



        }
    }
}
