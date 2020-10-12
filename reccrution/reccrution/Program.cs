using System;

namespace reccrution
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 2;
            int[] vector = new int[n];
            Gen01(0, vector);
        }
        static void Gen01(int index, int[] vector)
        {
            if (index >= vector.Length)
            {
                Print(vector);
            }
            else
            {
                for (int i = 0; i <= vector.Length; i++)
                {
                    vector[index] = i;
                    Gen01(index + 1, vector);
                }
            }
        }
        static void Print(int[] vector)
        {
            Console.WriteLine(string.Join("",vector));
        }


    }
}
