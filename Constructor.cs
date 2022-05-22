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

        //Console.WriteLine("d");
    }
}