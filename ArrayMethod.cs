using System;
using System.Linq;

namespace ArrayMethod {

    class Program{
        static void Main(string[] args){
            int[] nums={10,20,30};
            nums[1]=50;
            for(int i=0;i<nums.Length;i++){
              Console.WriteLine(nums[i]);
            }
            Array.Sort(nums);
            foreach(int j in nums){
                Console.WriteLine(j);
            }
            int x = nums.Max();
            int y = nums.Min();
            int total = nums.Sum();
            Console.WriteLine("Max value " + " " + x + " Min value " + y + " Total value " + total);
           
        }
    }
}