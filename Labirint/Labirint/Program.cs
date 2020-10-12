using System;
using System.Text;

namespace Labirint
{
    namespace PathsAlgorithm
    {
        class Program
        {
            static int StepsNumber = 0;
            static char[,] lab = new char[,]{
            {'-', '-', '-', '*', '-', '-', '-'},
            {'*', '*', '-', '*', '-', '-', '-'},
            {'-', '-', '-', '-', '-', '-', '-'},
            {'-', '*', '*', '*', '*', '*', '-'},
            {'-', '-', '-', '-', '-', '-', 'e'} };

            static void Main(string[] args)
            {
                FindPath(0, 0);
            }

            private static void FindPath(int row, int col)
            {
                if (!IsInBounds(row, col))
                {
                    return;
                }
                if (IsExit(row, col))
                {
                    Console.WriteLine("Path found!");
                    Console.WriteLine(StepsNumber);
                    PrintPath();
                }
                else if (!IsVisited(row, col) && IsPassable(row, col))
                {
                    Mark(row, col);
                    FindPath(row, col + 1);
                    FindPath(row + 1, col);
                    FindPath(row, col - 1);
                    FindPath(row - 1, col);
                    Unmark(row, col);
                }
            }
            private static void PrintPath()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        sb.Append(lab[i, j] + " ");
                    }
                    sb.AppendLine();
                }
                Console.WriteLine(sb.ToString().Trim());
            }
            private static void Mark(int row, int col)
            {
                StepsNumber++;
                lab[col, row] = '+';
                //lab[col, row] = $"{StepsNumber}";

            }
            private static void Unmark(int row, int col)
            {
                StepsNumber--;
                lab[col, row] = '-';
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
            private static bool IsVisited(int row, int col)
            {
                if (lab[row, col] == 'x')
                {
                    return true;
                }
                return false;

            }
            private static bool IsPassable(int row, int col)
            {
                if (lab[row, col] == '-')
                {
                    return true;
                }
                return false;

            }
            private static bool IsExit(int row, int col)
            {
                if (lab[row, col] == 'e')
                {
                    return true;
                }
                return false;

            }
        }
    }

}
