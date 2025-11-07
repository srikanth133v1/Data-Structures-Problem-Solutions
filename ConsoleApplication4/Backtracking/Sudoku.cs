using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Backtracking
{
    public class Sudoku
    {
        public static bool Solve(List<List<int>> A)
        {
            int row = -1, column = -1;
            if (!FindUnAssignedCell(A, ref row, ref column))
            {
                return true;
            }
            //Console.WriteLine("row: " + row + " col: " + column);
            for (int i = 1; i <= 9; i++)
            {
                //Console.WriteLine(i);
                if (IsValidRow(row, A, i) && IsValidColumn(column, A, i) && IsValidGrid(row, column, A, i))
                {
                    //Console.WriteLine(i);
                    A[row][column] = i;

                    if (Solve(A))
                    {
                        return true;
                    }
                    A[row][column] = 0;
                }
            }
            return false;
        }
        public static bool FindUnAssignedCell(List<List<int>> A, ref int row, ref int column)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (A[i][j] == 0)
                    {
                        row = i;
                        column = j;
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool IsValidRow(int row, List<List<int>> A, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (A[row][i] == num)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsValidColumn(int column, List<List<int>> A, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (A[i][column] == num)
                {
                    return false;
                }

            }
            return true;
        }
        public static bool IsValidGrid(int row, int column, List<List<int>> A, int num)
        {
            int rowStart = row - row % 3;
            int colStart = column - column % 3;
            for (int i = 0; i <  3; i++)
            {
                for (int j = 0; j <  3; j++)
                {
                    if (A[i + rowStart][j + colStart] == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
