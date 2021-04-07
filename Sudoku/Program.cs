using System;

namespace Sudoku
{
    class Program
    {
       delegate string returnAnswer();
        static void Main()
        {
            Solver solver = new Solver();
            SudokuBoards sudokuBoards = new SudokuBoards();
            Console.WriteLine("Do you want to solve the sudoku by computer?");
            Console.WriteLine("Write! Y/N");
            string answer = Console.ReadLine();
            string answer2 = solver.CheckAnswer(answer);
            //returnAnswer ra = new returnAnswer(solver.CheckAnswer);
            solver.runSudoku(sudokuBoards.hardBoard, answer2);
            Console.ReadKey();
        }
        
    }
}
