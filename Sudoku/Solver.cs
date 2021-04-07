using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    public class Solver
    {

        public bool generateBoard(int[,] testBoard, int N, string answer)
        {
            if (answer == "n")
            {
                return false;
            }
            Console.WriteLine("");
            int row = -1;
            int col = -1;
            string space = "|";
            if (N > 10 || N < 1)
            {
                throw new IndexOutOfRangeException("maxNumber cannot be bigger than 9 or less than 1");
            }
            //throw ArgumentOutOfRangeException;
            for (int i = 0; i < N; i++)
            {
                col = i;

                if (col > 0)
                    Console.WriteLine(" ");
                for (int j = 0; j < N; j++)
                {

                    row = j;
                    if (row > 0)
                    {
                        Console.Write(space);
                    }
                    Console.Write(testBoard[col, row]);
                }
            }
            Console.WriteLine("");
            return true;
        }
        // WRONG
        public bool solveSudoku(int[,] board, int maxNumber, int row, int col)
        {
            for (int i = 0; i < maxNumber; i++)
            {
                row = i;
                for (int j = 0; j < maxNumber; j++)
                {
                    col = j;
                    if (board[row, col] == 0)
                    {
                        for (int indexNumber = 1; indexNumber <= maxNumber; indexNumber++)
                        {
                            if (validator(board, col, row, indexNumber))
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

        public bool validator(int[,] board, int col, int row, int num)
        {
            int rowStart = (row / 3) * 3;
            int colStart = (col / 3) * 3;
            if (row > 9 || row < 0)
                throw new Exception("Row number of out range");
            else if (col > 9 || col < 0)
                throw new Exception("Col number of out range");
            else if (num > 9 || num < 0)
                throw new Exception("Index number of out range");

            for (int i = 0; i < 9; ++i)
            {
                if (board[i, col] == num) return false;
                if (board[row, i] == num) return false;
                if (board[rowStart + (i % 3), colStart + (i / 3)] == num) return false;
            }
            return true;
        }

        public string CheckAnswer(string answer)
        {
            if (answer == "y")
                return answer;
            else if (answer == "n")
                Environment.Exit(0);
            Console.WriteLine("Not right input");
            return "";
        }

        public bool runSudoku(int[,] board, string answer)
        {
            int maxNumber = board.GetLength(0);
            generateBoard(board, maxNumber, answer);
            if (solveSudoku(board, maxNumber, 0, 0))
            {
                generateBoard(board, maxNumber, answer);
                Console.WriteLine("Sudoku was solved without problem");
                return true;
            }
            else
            {
                Console.WriteLine("Sudoku was not solved");
                Environment.Exit(0);
                return false;
            }

        }


    }
}
