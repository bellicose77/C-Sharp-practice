using System;

namespace Overloading
{
    class Program
    {
        static int myMethod(int x,int y){
            return x+y;
        }
        static void Main(string[] args)
        {
            int sum = myMethod(4,6);
            Console.WriteLine(sum);

        }
    }
}