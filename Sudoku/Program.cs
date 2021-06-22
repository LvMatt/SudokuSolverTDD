using System;

namespace Sudoku
{
    class Program
    {
       delegate string returnAnswer();
        static void Main()
        {
            SudokuLogic solver = new SudokuLogic();
            SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();
            SudokuBoards sudokuBoards = new SudokuBoards();
            Console.WriteLine("Do you want to solve the sudoku by computer?");
            Console.WriteLine("Write! Y/N");

            string answer = sudokuBoardDisplayer.CheckAnswer(Console.ReadLine());

            Console.WriteLine("Choose Sudoku: ");
            Console.WriteLine("1, Easy Sudoku");
            Console.WriteLine("2, Difficult Sudoku: ");
            Console.WriteLine("3, Extreme Difficult");
            int[,] sudokuBoard = sudokuBoardDisplayer.SelectSudokuBoard(Int32.Parse(Console.ReadLine()));
                
            //Console.WriteLine("Write name of the of file path");
            solver.runSudoku(sudokuBoard);
            Console.ReadKey();
        }
        
    }
}
