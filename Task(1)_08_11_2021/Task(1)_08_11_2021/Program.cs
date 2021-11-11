using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1__08_11_2021;

namespace Task_1__08_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFigure interface yaratmaq, CalculateArea ve CalculatePerimeter method-u olsun.
            //Rectangle, Circle, Triangle, Square bu interface-in methodlarini implement etsin.
            IFigure rectangle = new Rectangle(34,35);
            IFigure circle = new Circle(15);
            IFigure triangle = new Triangle(25, 13);
            IFigure square = new Square(16);

            Console.WriteLine("Duzbucagin sahesi {0}-a beraberdir", rectangle.CalculateArea());
            Console.WriteLine("Duzbucagin perimetri {0}-a beraberdir", rectangle.CalculatePerimeter());
            Console.WriteLine("Dairenin sahesi {0}-a beraberdir", circle.CalculateArea());
            Console.WriteLine("Dairenin perimetri {0}-a beraberdir", circle.CalculatePerimeter());
            Console.WriteLine("Ucbucagin sahesi {0}-a beraberdir",triangle.CalculateArea());
            Console.WriteLine("Ucbucagin perimetri {0}-a beraberdir",triangle.CalculatePerimeter());
            Console.WriteLine("Dordbucagin sahesi {0}-a beraberdir", rectangle.CalculateArea());
            Console.WriteLine("Dordbucagin perimetri {0}-a beraberdir", rectangle.CalculatePerimeter());
            Console.ReadKey();


        }
    }
    interface IFigure
    {
        double CalculateArea();
        double CalculatePerimeter();

    }
    public class Rectangle : IFigure
    {
        private double en;
        private double uz;

        public double CalculateArea()
        {
            double area = en * uz;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perim = (en+uz)*2;
            return perim;
        }
        public Rectangle(double en,double uz)
        {
            if(en>=0 && uz>=0)
            {
                this.en = en;
                this.uz = uz;
    }
            else
            {
                Console.WriteLine("negativ eded daxil etmek olmaz!!!");
            }

        }
    }
    public class Circle : IFigure
    {
        private double radius;
        const double pi=3.14;
       

        public double CalculateArea()
        {
            double area = radius*radius*pi;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perim = pi * 2*radius;
            return perim;
        }
        public Circle(double radius)
        {
            if (radius >= 0)
            {
                this.radius = radius;
                
            }
            else
            {
                Console.WriteLine("negativ eded daxil etmek olmaz!!!");
            }

        }
    }
    public class Triangle : IFigure
    {
        private double en;
        private double uz;



        public double CalculateArea()
        {
            double area = (en * uz) / 2;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perim = en+2*uz;
            return perim;
        }
        public Triangle(double en,double uz)
        {
            if (en >= 0 && uz>=0)
            {
                this.en = en;
                this.uz = uz;
            }
            else
            {
                Console.WriteLine("negativ eded daxil etmek olmaz!!!");
            }

        }
    }
    public class Square : IFigure
    {
        private double teref;
        



        public double CalculateArea()
        {
            double area = (4*teref);
            return area;
        }

        public double CalculatePerimeter()
        {
            double perim = teref*4;
            return perim;
        }
        public Square(double teref)
        {
            if (teref >= 0)
            {
                this.teref = teref;
            }
            else
            {
                Console.WriteLine("negativ eded daxil etmek olmaz!!!");
            }

        }
    }
}
