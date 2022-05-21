using System;

namespace Overloading
{
    class Program
    {
        static int myMethod(int x,int y){
            return x+y;
        }

        static double myMethod(double x,double y){
            return x+y;
        }
        static void Main(string[] args)
        {
            int sum = myMethod(4,6);
            double sum1 = myMethod(5.7,8.7);
            Console.WriteLine(sum);
            Console.WriteLine(sum1);

        }
    }
}