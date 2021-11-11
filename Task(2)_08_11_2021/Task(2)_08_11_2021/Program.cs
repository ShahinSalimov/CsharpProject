using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2__08_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISum, IMultiply, IDifference, IDivide interface-leri olsun,
            //her birinde bir dene return type "double" olan
            //ve parametrinde "params double[] numbers" method olsun.
            //Bu 4 interface-i Calculator.cs class-inda her birini implement edin.
            //Meselen: ISum interface-inde Sum() methodu olacaq
            //ve arrayin butun elementlerini cemleyib qaytaracaq.
            //Multiply - vurma, Difference -chixma, Divide - bolme.
            //Sonda Program.cs-de Calculator.cs-i chagirib,
            //verdiyiniz deyerlere uygun method chagirib neticeni gosterin.
            Calculator calc = new Calculator();
            Console.WriteLine("elementlerin cixilmasi : cavab : {0}",calc.difference(3,5,6,7,3,4,5));
            Console.WriteLine("elementlerin bolunmesi : cavab : {0}", calc.divide(6,4,7,8,3,4,5));
            Console.WriteLine("elementlerin vurulmasi : cavab : {0}", calc.multiply(3,5,6,7,8,9));
            Console.WriteLine("elementlerin toplanmasi : cavab : {0}", calc.sum(9,8,7,6,5,4,3,5,6,7));
            Console.ReadKey();

        }
    }
    interface ISum
    {
        double sum();
    }
    interface IMultiply
    {
        double multiply();

    }
    interface IDifference
    {
        double difference();

    }
    interface IDivide
    {
        double divide();
    }
    public class Calculator : ISum, IMultiply, IDivide, IDifference
    {
        public double difference(params double[] numbers)
        {
            double diff_box = numbers[0];
            for(int i = 0; i < numbers.Length; i++)
            {
                diff_box -= numbers[i];
            }
            return diff_box;
        }

        public double difference()
        {
            throw new NotImplementedException();
        }

        public double divide(params double[] numbers)
        {
            double div_box = 0;
            for (int i=0; i<numbers.Length; i++)
            {
                div_box /= numbers[i];
                if (numbers[i] == 0)
                {
                    Console.WriteLine("0-a bolme yoxdur!!!");
                }

            }
            return div_box;
        }

        public double divide()
        {
            throw new NotImplementedException();
        }

        public double multiply(params double[] numbers)
        {
            double multi_box = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                multi_box *= numbers[i];
                if (numbers[i] == 0)
                {
                    Console.WriteLine("0-a vurma yoxdur!!!");
                }
            }
            return multi_box;
        }

        public double multiply()
        {
            throw new NotImplementedException();
        }

        public double sum(params double[] numbers)
        {
            double sum_box = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum_box += numbers[i];
            }
            return sum_box;
        }

        public double sum()
        {
            throw new NotImplementedException();
        }
    }
}
