using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3__08_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student.cs olsun, Name, Surname, Age propertyleri olsun, ancaq constructorda set olsun.
            //Neche defe instance aldigimizi qaytaran Counter olsun, hansiniki yalniz constructorda set ede bilek.

            Student telebe1 = new Student("Namiq","Ehmedov",28);
            Student telebe2 = new Student("Nermin", "Eliyeva", 30);

            Console.WriteLine(telebe1.Counter);
            Console.WriteLine(telebe2.Counter);
            Console.ReadKey();

        }
    }
    public class Student
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public int Counter=0;
        public static int id;

        public Student(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            if(Name==name&& Surname ==surname&& Age == age)
            {
                Counter=id++;
            }
            

        }
    }
}
