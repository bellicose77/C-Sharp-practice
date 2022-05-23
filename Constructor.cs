using System;

namespace  Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car();
            Console.WriteLine(ford.model);

        }
    }

    class Car{
        public string model;

        public Car()
        {
            model="Ford";
        }

       public void print()
       {
           
       }
    }
    class Bus{
        public string model;
        public string color;
        public int year;

        public Bus(string )
    }
}