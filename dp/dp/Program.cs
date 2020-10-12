using System;
using System.Collections.Generic;

namespace dp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 1, 4, 2 };
            List<int> result = new List<int>();

            
            for (int i = 0; i < numbers.Length; i++)
            {
                result.Add(numbers[i]);

                if (result.Count > 1)
                {
                    foreach (var num in result)
                    {
                        if (!result.Contains(num + numbers[i]))
                        {
                            result.Add(num + numbers[i]);
              
                        }
                        
                    }
                }               
            }
            foreach (var res in result)
            {
                Console.WriteLine(res.ToString());
            }

        }
    }
}
