using System;
using System.Collections.Generic;

namespace combinations
{
    class Program
    {

        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int[] vector = new int[2];
            //GenNumbers(0, 1, vector, n);
            int n = int.Parse(Console.ReadLine());

            Permutations(new List<int>(), 0, new int[n]);

        }
        private static void Permutations(List<int> marked, int index, int[] vector)
        {
            if (vector.Length <= index)
            {
                NewMethod(vector);
            }
            else
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    if (!   marked.Contains(i))
                    {
                        marked.Add(i);
                        vector[index] = i + 1;
                        Permutations(marked, index + 1, vector);
                        marked.Remove(i);
                    }
                }
            }
        }

        //public static void Gen(int index, int[] vector)
        //{
        //    if (index >= vector.Length)
        //    {
        //        NewMethod(vector);
        //    }
        //    else
        //    {
        //        for (int i = 0; i <= 1; i++)
        //        {
        //            vector[index] = i;
        //            Gen(index + 1, vector);
        //        }
        //    }




        //}
        //private static void GenNumbers(int index, int num, int[] vector, int n)
        //{

        //    int[,] StorageOfResult = new int[n, ','];
        //    if (index >= vector.Length)
        //    {
        //        NewMethod(vector);
        //    }
        //    else
        //    {
        //        for (int i = num; i <= n; i++)
        //        {


        //            vector[index] = i;
        //            GenNumbers(index + 1, i + 1, vector, n);


        //        }
        //    }
        //}

        private static void NewMethod(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i]);
            }
            Console.WriteLine();
        }




        




    }
}
