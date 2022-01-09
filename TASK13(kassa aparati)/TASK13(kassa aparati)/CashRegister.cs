using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK13_kassa_aparati_
{
    class CashRegister
    {
        List<int> Kassa = new List<int>();
        public Dictionary<string, double> AddSale(string curency,double mebleq)
        {
            Dictionary<string, double> curen = new Dictionary<string, double>();
            curen.Add(curency, mebleq);
            foreach (var item in curen)
            {
                if (item.Key==Currency.EURO.ToString())
                {
                    double result = mebleq * 2;
                    TotalSalesCount++;
                    TotalAmount += result;

                }
                else if (item.Key == Currency.USD.ToString())
                {
                    double result = mebleq * 1.7;
                    TotalSalesCount++;
                    TotalAmount += result;

                }
                else if (item.Key == Currency.TL.ToString())
                {
                    double result = mebleq * 0.40;
                    TotalSalesCount++;
                    TotalAmount += result;

                }
                else
                {
                    Console.WriteLine("BELE BIR VALYUTA YOXDUR...");
                }
            }
            return curen;
        }
        public void RemoveSale(string curency, double mebleq)
        {

        }
        //public CashRegister(double totalamount,int totalsalescount)
        //{
        //    TotalAmount = totalamount;
        //    TotalSalesCount = totalsalescount;
        //}
        public double TotalAmount = 0;
        public int TotalSalesCount = 0;

    }
    public enum Currency
    {
        EURO,
        USD,
        TL
    }
    public enum PaymentType
    {
        CARD,
        CASH
    }
}
