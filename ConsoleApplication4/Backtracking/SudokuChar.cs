using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Backtracking
{
    public class SudokuChar
    {
        bool sudoku2(char[][] grid)
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grid[i][j] != '.')
                    {


                        if (!IsValidRow(i, grid, grid[i][j], j) || !IsValidColumn(j, grid, grid[i][j], i) || !IsValidGrid(i, j, grid, grid[i][j], i, j))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public static bool FindUnAssignedCell(char[][] A, ref int row, ref int column)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (A[i][j] == '.')
                    {
                        row = i;
                        column = j;
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool IsValidRow(int row, char[][] A, char num, int colPosition)
        {
            for (int i = 0; i < 9; i++)
            {
                if (A[row][i] == num && i != colPosition)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsValidColumn(int column, char[][] A, char num, int rowPosition)
        {
            for (int i = 0; i < 9; i++)
            {
                if (A[i][column] == num && i != rowPosition)
                {
                    return false;
                }

            }
            return true;
        }
        public static bool IsValidGrid(int row, int column, char[][] A, char num, int rowPosition, int colPosition)
        {
            int rowStart = row - row % 3;
            int colStart = column - column % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (A[i + rowStart][j + colStart] == num && ((i + rowStart) != rowPosition) && ((j + colStart) != colPosition))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
