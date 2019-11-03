using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_7.FirstTasks
{
    class ArraySort
    {
        
        public void Sort()
            {
                Console.WriteLine("Enter an amount of elements in array");
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[n];
                Console.WriteLine("Enter your elements(divide by Enter)");
                for (int i = 0; i < n; i++)
                {
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(nums);
                Console.WriteLine("Sorted array:");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine(nums[i]);
                }


            }
       
    }
}