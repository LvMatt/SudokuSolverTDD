using Moq;
using NUnit.Framework;
using Sudoku;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuTestsNUnit
{
    [TestFixture]
    class SudokuLogicTest
    {
        // Local function ARRANGE

        SudokuLogic solver = new SudokuLogic();
        static SudokuBoards sudokuBoards = new SudokuBoards();
        SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();
        int maxNumber = 9;
        int row = 1;
        int col = 1;
        int num = 1;
        static int[,] board = sudokuBoards.easyBoard;

        [TestCase]
        public void SolveSudokuTest()
        {

            // ACT

            var testSudokuSolver = solver.solveSudoku(board, maxNumber, row, col);
            
            // ASSERT

            Assert.IsTrue(testSudokuSolver);
        }

        [TestCase(10)]
        public void SolveSudokuMaxNumberAboveRange(int num)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => solver.solveSudoku(board, num, row, col), 
                Throws.Exception);
        }

        [TestCase(0)]
        public void SolveSudokuMaxNumberBelowRange(int num)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => solver.solveSudoku(board, num, row, col), Throws.Exception);
        }

        [TestCase]
        public void SolveSudokuTestFailDueToWrongSudokuBoard()
        {
            // ACT

            var testSudokuSolver = solver.solveSudoku(sudokuBoards.easyBoardWrong, maxNumber, row, col);
            
            // ASSERT

            Assert.IsFalse(testSudokuSolver);
        }

        //[TestCase]
        //public void SolveSudokuFunctionCallItself()
        //{

        //    var testSudokuSolver = solver.solveSudoku(sudokuBoards.easyBoardWrong, maxNumber, row, col);
        //    Assert.GreaterOrEqual(1, testSudokuSolver);
        //}


        //[Test]
        //public void CompareTwoSudokusTest()
        //{
        //    int maxNumber = 9;
        //    var testSudokuSolver = solver.solveSudoku(sudokuBoards.easyBoard, maxNumber, 0, 0);
        //    var testSudokuMapper = sudokuBoardDisplayer.generateBoard(sudokuBoards.extremeBoard, maxNumber);
        //    Assert.AreEqual(testSudokuSolver, testSudokuMapper);
        //}

        [Test]
        public void CompareTwoSameSudokus()
        {
            // ARRANGE

            var testSudokuSolver = sudokuBoards.easyBoard;
            var expectedValue = sudokuBoards.easyBoard;

            // ASSERT

            Assert.AreSame(testSudokuSolver, expectedValue);
        }

        [Test]
        public void CompareTwoDifferentSudokus()
        {


            // ARRANGE

            var testSudokuSolver = sudokuBoards.easyBoard;
            var testSudokuMapper = sudokuBoards.extremeBoard;

            // ASSERT

            Assert.AreNotEqual(testSudokuSolver, testSudokuMapper);
        }
    }
}
