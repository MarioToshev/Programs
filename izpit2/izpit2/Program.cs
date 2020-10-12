using System;
using System.Collections.Generic;

namespace izpit2
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            

            Permutate(CreateArray(n), 0, new List<long>());
        }
        public static long[] CreateArray(long n)
        {
            long[]  arr = new long[n];
            while (n != 0)
            {
                arr[n-1] = n;
                n--;
            }
            return arr;
        }

        public static void Permutate(long[] nums , long index, List<long> marked)
        {
            if (nums.Length <= index)
            {
                Print(nums);
               
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!marked.Contains(i))
                    {
                        marked.Add(i);
                        nums[index] = i + 1;
                        Permutate(nums,index + 1, marked);
                        marked.Remove(i);
                    }
                }   
            }
        }

        private static void Print(long[] nums)
        {
            foreach (var item in nums)
            {
                Console.Write(string.Join(" ", item));
            }
            Console.WriteLine();
        }
    }
}
