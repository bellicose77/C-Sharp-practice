using System;

namespace OOP
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
    class Car{
        public string color = "BLue";
    }
}