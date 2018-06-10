using System;
using System.Collections.Generic;

namespace _06._8QueemPuzzle
{
    class Program
    {
        private const int Size = 8;
        static int[,] board = new int[Size,Size];

        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedCols = new HashSet<int>();
        static HashSet<int> attackedLeftDiagon = new HashSet<int>();
        static HashSet<int> attackedRightDiagon = new HashSet<int>();

        static void Solve(int row)
        {
            if (row == Size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAttackedFields(row,col);
                        Solve(row + 1);
                        UnmarkAttackedFields(row, col);
                    }
                }
            }
        }

        private static void UnmarkAttackedFields(int row, int col)
        {
            attackedRows.Remove(row);
            attackedCols.Remove(col);
            attackedLeftDiagon.Remove(col - row);
            attackedRightDiagon.Remove(row + col);
            board[row, col] = 0;

        }

        private static void MarkAttackedFields(int row, int col)
        {
            attackedRows.Add(row);
            attackedCols.Add(col);
            attackedLeftDiagon.Add(col - row);
            attackedRightDiagon.Add(row + col);
            board[row, col] = 1;

        }

       // private static int solFound = 0;
        private static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (board[row, col] == 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //solFound++;
           // Console.WriteLine(solFound);
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var possOcup = attackedRows.Contains(row)
                           || attackedCols.Contains(col)
                           || attackedLeftDiagon.Contains(col - row)
                           || attackedRightDiagon.Contains(row + col);
            return !possOcup;
            ////left - up  diagonal
            //for (int i = 1; i < Size; i++)
            //{
            //    int currentRow = row - i;
            //    int currentCol = col - i;

            //    if (currentRow < 0 || currentRow >= Size
            //        || currentCol < 0 || currentCol >= Size)
            //    {
            //        break;
            //    }
            //    //queen here
            //    if (board[currentRow, currentCol] == 1)
            //    {
            //        return false;
            //    }
            //}
            ////right - up  diagonal
            //for (int i = 1; i < Size; i++)
            //{
            //    int currentRow = row - i;
            //    int currentCol = col + i;

            //    if (currentRow < 0 || currentRow >= Size
            //        || currentCol < 0 || currentCol >= Size)
            //    {
            //        break;
            //    }

            //    //queen here
            //    if (board[currentRow, currentCol] == 1)
            //    {
            //        return false;
            //    }
            //}
            ////left - down  diagonal
            //for (int i = 1; i < Size; i++)
            //{
            //    int currentRow = row + i;
            //    int currentCol = col - i;

            //    if (currentRow < 0 || currentRow >= Size
            //        || currentCol < 0 || currentCol >= Size)
            //    {
            //        break;
            //    }

            //    //queen here
            //    if (board[currentRow, currentCol] == 1)
            //    {
            //        return false;
            //    }
            //}
            ////right - down  diagonal
            //for (int i = 1; i < Size; i++)
            //{
            //    int currentRow = row + i;
            //    int currentCol = col + i;

            //    if (currentRow < 0 || currentRow >= Size
            //        || currentCol < 0 || currentCol >= Size)
            //    {
            //        break;
            //    }

            //    //queen here
            //    if (board[currentRow, currentCol] == 1)
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }

        static void Main() => Solve(0);
    }
}
