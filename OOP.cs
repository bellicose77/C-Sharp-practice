using System;

namespace OOP
{
    class Car
    {
        string color = "Blue";
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}