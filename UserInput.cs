using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args){
            //Console.ReadLine("Enter your number");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);
        }
    }
}