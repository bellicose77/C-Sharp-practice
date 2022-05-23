using System;

namespace  Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car();
            Bus ex = new Bus("hanif","blue",2012);
            ex.output();
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

        public Bus(string modelName,string colorName,int year)
        {
            model = modelName;
            color = colorName;
            year = year;
        }

        public void output()
        {
            Console.WriteLine("Bus name is " + model + " and color is " + color + " introduced in " + year );
        }
    }
}