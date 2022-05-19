using System;

namespace Loop{
    class Program{
        static void Main(string[] args){
            int i =0;
            while(i<5){
                Console.WriteLine(i);
                i++;
            }

            for(int j=0;j<10;j++){
                Console.WriteLine(j);
            }
        }
    }
}