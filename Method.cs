using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
             Car myObj = new Car();
             myObj.color="blue";
             myObj.maxspeed = 30;
             myObj.myMethod();
        }
    }
    class Car
    {
        string color;
        int maxspeed;

        public void myMethod()
        {
            Console.WriteLine(color);
            Console.WriteLine(maxspeed);
        }


    }
}