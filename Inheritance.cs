using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.Monk();
        }
    }

    class Vechle
    {
        public string model = "ford";
        public void Monk()
        {
            Console.WriteLine("Blba blba");
        }

    }

    class Car : Vechle
    {
        public string model ="Mustag";
    }
}