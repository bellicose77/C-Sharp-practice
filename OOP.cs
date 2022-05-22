using System;

namespace OOP
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            myObj.full();
        }
    }
    class Car{
        public string color = "BLue";
        int maxspeed = 20;

        public void full()
        {
            Console.WriteLine("The car is going fast");
        }
    }
}