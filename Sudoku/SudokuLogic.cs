using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sudoku
{
    public class SudokuLogic
    {
        static SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();
        static SudokuBoards sudokuBoards = new SudokuBoards();
        int numberOfinvokes = 0;

        public bool solveSudoku(int[,] board, int maxNumber, int row, int col)
        {
            if (maxNumber > 9 || maxNumber < 1)
                throw new Exception("Max number of out range");
            for (int i = 0; i < maxNumber; i++)
            {
                row = i;
                for (int j = 0; j < maxNumber; j++)
                {
                    col = j;
                    if (board[row, col] == 0)
                    {
                        if (!ExitSudoku())
                            return false;

                        for (int indexNumber = 1; indexNumber <= maxNumber; indexNumber++)
                        {
                            if (validatorWrapper(board, col, row, indexNumber))
                            {

                                board[row, col] = indexNumber;
                                if (solveSudoku(board, 9, row, col))
                                {
                                    return true;
                                }
                                else
                                    board[row, col] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }


        public bool validatorWrapper(int[,] board, int col, int row, int num)
        {
            numberOfinvokes++;
            if (!colValidator(board, col, row, num)) return false;
            if (!rowValidator(board, col, row, num)) return false;
            if (!groupValidator(board, col, row, num)) return false;
            return true;
        }


        public bool rowValidator(int[,] board, int col, int row, int num)
        {
            if (row > 9 || row < 0)
                throw new Exception("Row number of out range");
            for (int i = 0; i < 9; ++i)
                if (board[i, col] == num) return false;
            return true;
        }

        public bool colValidator(int[,] board, int col, int row, int num)
        {
            if (col > 9 || col < 0)
                throw new Exception("Col number of out range");

            for (int i = 0; i < 9; ++i)
                if (board[row, i] == num) return false;
            return true;
        }

        // Checks 3x3 group of numbers 
        public bool groupValidator(int[,] board, int col, int row, int num)
        {
            if (num > 9 || num < 0)
                throw new Exception("Row number of out range");
            int rowStart = (row / 3) * 3;
            int colStart = (col / 3) * 3;
            for (int i = 0; i < 9; ++i)
                if (board[rowStart + (i % 3), colStart + (i / 3)] == num) return false;
            return true;
        }

        
        public bool ExitSudoku()
        {
            if (numberOfinvokes > 10000)
                return false;
            return true;
        }

        public bool runSudoku(int[,] board)
        {
     
            int maxNumber = board.GetLength(0);
            sudokuBoardDisplayer.generateBoard(board, maxNumber);
            if (solveSudoku(board, maxNumber, 0, 0))
            {
                sudokuBoardDisplayer.generateBoard(board, maxNumber);
                Console.WriteLine("Sudoku was solved without problem");
                return true;
            }
            else
            {
                Console.WriteLine("Sudoku was not solved");
                return false;
                //Environment.Exit(0);
            }
        }
    }
}
