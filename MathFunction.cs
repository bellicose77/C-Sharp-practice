using System;

namespace MathFunc
{
    class Program
    {
        static void Main(string[] args){
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convertk.ToInt32(Console.ReadLine());
            if(x>y){
                Console.WriteLine("X is greater than y");
            }
            else{
                Console.WriteLine("y is greater than x");
            }
        }
    }
}