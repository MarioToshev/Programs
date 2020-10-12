using System;

namespace Izpit
{
    class Program
    {
        public static int numberOf = 0;

        static void Main(string[] args)
        {

         
            int[] bank = { 100, 50, 20, 10, 5, 2, 1 };


            int n = int.Parse(Console.ReadLine());

            Calculate(n, 0, bank, 0);
       
        }

        public static void Calculate(int n , int desiredNum, int[] bank, int  index)
        {
            if (desiredNum == n)
            {
                Console.WriteLine(numberOf);
            }
            else
            {
                if ((desiredNum + bank[index]) <= n)
                {
                    desiredNum += bank[index];
                    numberOf++;
                    Calculate(n, desiredNum, bank, index);
                }
                else
                {
                    Calculate(n, desiredNum, bank, index+1);
                }
            }
        }
    }
}
