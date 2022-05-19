using System;
namespace StringMethod
{
    class Program{
        static void Main(string[] args){
            string s = "hello worLd";
            int x = s.Length;
            string upper = s.ToUpper();
            string lower = s.ToLower();
            Console.WriteLine("Length of String " + x);
            Console.WriteLine("all upercase " + upper);
            Console.WriteLine("all lower case " + lower);
        }
    }
}