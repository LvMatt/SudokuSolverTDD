using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sudoku
{
    public class SudokuBoardDisplayer
    {

        public bool generateBoard(int[,] testBoard, int N)
        {
            Console.WriteLine("");
            int row = -1;
            int col = -1;
            string space = "|";
            if (N > 10 || N < 1)
                throw new Exception("maxNumber cannot be bigger than 9 or less than 1");
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
                    if (col > 9)
                        return false;
                }

                if (col > 9)
                    return false;
            }
            Console.WriteLine("");
            return true;
        }




        //public int[,] ReadFile(string filename)
        //{
        //    int[,] sudokuBoard = new int[9, 9];
        //    int row = 0; int col = 0;
        //    try
        //    { 
        //        var sudokuBoardFile = File.ReadAllText(filename);
        //        foreach (var fileRow in sudokuBoardFile.Split("\n"))
        //        {
        //            foreach (var fileCol in fileRow.Trim().Split(" "))
        //            {
        //                sudokuBoard[row, col] = int.Parse(fileRow.Trim());
        //                col++;
        //            }
        //            row++;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Something went wrong while reading file " + ex.Message);
        //    }
        //    return sudokuBoard;
        //}

        public string CheckAnswer(string answer)
        {
            if (answer == "y" || answer == "Y")
                return answer;
            Console.WriteLine("Not right input");
            return String.Empty;
            //Environment.Exit(0);
        }

        public int[,] SelectSudokuBoard(int sudoku)
        {
            if (sudoku > 3 || sudoku < 1)
                throw new Exception("Select only input among 1 to 3");
            SudokuBoards sudokuBoards = new SudokuBoards();
            switch (sudoku)
            {
                case 1:
                    return sudokuBoards.easyBoard;
                case 2:
                    return sudokuBoards.hardBoard;
                case 3:
                    return sudokuBoards.impossibleBoard;
                default:
                    return sudokuBoards.easyBoard;
            }
        }

    }
}
