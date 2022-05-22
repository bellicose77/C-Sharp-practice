using System;

namespace  Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car();

        }
    }

    class Car{
        string model;

        public Car()
        {
            model="Ford";
        }
    }
}