using System;
using System.Collections.Generic;
using System.Text;
namespace Labyrinth
{
    class Program
    {
        static int numberOfSteps = 0;
        static char[,] labyrinth = new char[,]{
            {'-', '-', '-', '*', '-', '-', '-'},
            {'*', '*', '-', '*', '-', '-', '-'},
            {'-', '-', '-', '-', '-', '-', '-'},
            {'-', '*', '*', '*', '*', '*', '-'},
            {'-', '-', '-', '-', '-', '-', 'e'} };
        //static void Main(string[] args)
        //{
        //    FindPath(0, 0);
        //}
        private static void FindPath(int row, int col)
        {
            if (!IsInBounds(row, col))
            {
                return;
            }
            if (IsExit(row, col))
            {
                Console.WriteLine("Path found!");
                Console.WriteLine(numberOfSteps);
                PrintLabyrinth();
            }
            else if (!IsVisisted(row, col) && IsPassable(row, col))
            {
                Mark(row, col);
                FindPath(row, col + 1);
                FindPath(row + 1, col);
                FindPath(row, col - 1);
                FindPath(row - 1, col);
                Unmark(row, col);
            }
        }
        private static void Unmark(int row, int col)
        {
            labyrinth[col, row] = '-';
            numberOfSteps--;
        }
        private static void Mark(int row, int col)
        {
            numberOfSteps++;
            labyrinth[col, row] = 'x';
        }
        private static void PrintLabyrinth()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    sb.Append(labyrinth[i, j] + " ");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString().Trim());
        }
        private static bool IsPassable(int row, int col)
        {
            if (labyrinth[col, row] == '-')
            {
                return true;
            }
            return false;
        }
        private static bool IsVisisted(int row, int col)
        {
            if (labyrinth[col, row] == 'x')
            {
                return true;
            }
            return false;
        }
        private static bool IsExit(int row, int col)
        {
            if (labyrinth[col, row] == 'e')
            {
                return true;
            }
            return false;
        }
        private static bool IsInBounds(int row, int col)
        {
            if (col >= 5 || col < 0)
            {
                return false;
            }
            if (row >= 7 || row < 0)
            {
                return false;
            }
            return true;
        }
    }
}