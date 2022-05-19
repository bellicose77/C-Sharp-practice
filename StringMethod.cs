using System;
namespace StringMethod
{
    class Program{
        static void Main(string[] args){
            string s = "hello worLd";
            int x = s.Length;
            string upper = s.ToUpper();
            Console.WriteLine("Length of String " + x);
            Console.WriteLine("all upercase " + upper);
        }
    }
}