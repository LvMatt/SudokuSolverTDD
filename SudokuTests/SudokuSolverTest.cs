using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace SudokuTests
{
    [TestClass]
    public class SudokuSolverTest
    {
//        int[,] testboard = new int[,]
//               {
//                {0, 4, 0, 0, 0, 0, 1, 7, 9},
//                {0, 0, 2, 0, 0, 8, 0, 5, 4},
//                {0, 0, 6, 0, 0, 5, 0, 0, 8},
//                {0, 8, 0, 0, 7, 0, 9, 1, 0},
//                {0, 5, 0, 0, 9, 0, 0, 3, 0},
//                {0, 1, 9, 0, 6, 0, 0, 4, 0},
//                {3, 0, 0, 4, 0, 0, 7, 0, 0},
//                {5, 7, 0, 1, 0, 0, 2, 0, 0},
//                {9, 2, 8, 0, 0, 0, 0, 6, 0}
//        };

//        int[,] testboardWrong = new int[,]
//       {
//                {4, 4, 0, 0, 0, 0, 1, 7, 9},
//                {0, 0, 2, 0, 0, 8, 0, 5, 4},
//                {0, 0, 6, 0, 0, 5, 0, 0, 8},
//                {0, 8, 0, 0, 7, 0, 9, 1, 0},
//                {0, 5, 0, 0, 9, 0, 0, 3, 0},
//                {0, 1, 9, 0, 6, 0, 0, 4, 0},
//                {3, 0, 0, 4, 0, 0, 7, 0, 0},
//                {5, 7, 0, 1, 0, 0, 2, 0, 0},
//                {9, 2, 8, 0, 0, 0, 0, 6, 0}
//};

//        int[,] rightboard = new int[,]
//        {
//            {8, 4, 5, 6, 3, 2, 1, 7, 9},
//            {7, 3, 2, 9, 1, 8, 6, 5, 4},
//            {1, 9, 6, 7, 4, 5, 3, 2, 8},
//            {6, 8, 3, 5, 7, 4, 9, 1, 2},
//            {4, 5, 7, 2, 9, 1, 8, 3, 6},
//            {2, 1, 9, 8, 6, 3, 5, 4, 7},
//            {3, 6, 1, 4, 2, 9, 7, 8, 5},
//            {5, 7, 4, 1, 8, 6, 2, 9, 3},
//            {9, 2, 8, 3, 5, 7, 4, 6, 1}
//        };

//        int[,] wrongboard = new int[,]
//        {
//            {8, 4, 5, 6, 3, 2, 1, 7, 9},
//            {7, 3, 2, 9, 1, 8, 6, 5, 4},
//            {1, 9, 6, 7, 4, 5, 3, 2, 8},
//            {6, 8, 3, 5, 7, 4, 9, 1, 2},
//            {4, 5, 7, 2, 9, 1, 8, 3, 6},
//            {2, 1, 9, 8, 6, 3, 5, 4, 7},
//            {3, 1, 1, 4, 1, 9, 7, 8, 5},
//            {5, 7, 4, 1, 8, 6, 2, 9, 3},
//            {9, 2, 8, 3, 5, 7, 4, 6, 1}
//        };

//        SudokuLogic solver = new SudokuLogic();
//        SudokuBoards sudokuBoards = new SudokuBoards();
//        SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

//        [TestMethod]
//        public void SolveSudokuTest()
//        {
//            int maxNumber = 9;
//            int row = 0;
//            int col = 0;
//            var testSudokuSolver = solver.solveSudoku(testboard, maxNumber, row, col);
//            Assert.IsTrue(testSudokuSolver);
//        }
//        [TestMethod]
//        public void SolveSudokuTestFail()
//        {
//            int maxNumber = 9;
//            int row = 0;
//            int col = 0;
//            var testSudokuSolver = solver.solveSudoku(testboard, maxNumber, row, col);
//            Assert.IsTrue(testSudokuSolver);
//        }

//        [TestMethod]
//        public void CompareTwoSudokusTest()
//        {
//            int maxNumber = 9;
//            var testSudokuSolver = solver.solveSudoku(testboard, maxNumber, 0, 0);
//            string answer = "y";
//            var testSudokuMapper = sudokuBoardDisplayer.generateBoard(rightboard, maxNumber, answer);
//            Assert.AreEqual(testSudokuSolver, testSudokuMapper);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(Exception))]
//        public void RowParameterAboveRange()
//        {
//            int col = 0;
//            int row = 10;
//            int num = 1;
//            solver.rowValidator(testboard, col, row, num);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(Exception))]
//        public void ColParameterAboveRange()
//        {
//            int row = 0;
//            int col = 10;
//            int num = 1;
//            solver.colValidator(testboard, col, row, num);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(Exception))]
//        public void IndexParameterAboveRange()
//        {
//            solver.groupValidator(testboard, 0, 0, 10);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(IndexOutOfRangeException))]
//        public void ColParameterNegativeRange()
//        {
//            int row = 1;
//            int col = -3;
//            int num = 1;
//            solver.colValidator(testboard, row, col, num);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(IndexOutOfRangeException))]
//        public void RowarameterNegativeRange()
//        {
//            int row = -3;
//            int col = 0;
//            int num = 0;
//            solver.rowValidator(testboard, row, col, num);
//        }
//        [TestMethod]
//        [ExpectedException(typeof(Exception))]
//        public void IndexParameterNegativeRange()
//        {
//            int row = 0;
//            int col = 0;
//            int num = -3;
//            solver.groupValidator(testboard, row, col, num);
//        }

//        [TestMethod]
//        public void RunSudokuTest()
//        {
//            var testRunSudoku = solver.runSudoku(testboard, "y");
//            if (testRunSudoku)
//                Assert.IsTrue(testRunSudoku);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(IndexOutOfRangeException))]
//        public void RunWrongSudoku()
//        {
//            var wrongSudokuBoard = sudokuBoards.wrongSudokuBoard;
//            string answer = "y";
//            solver.runSudoku(wrongSudokuBoard, answer);
//        }

//        [TestMethod]
//        public void CheckRightAnswerSudokuTest()
//        {
//            var answer = "y";
//            var testValidAnswer = sudokuBoardDisplayer.CheckAnswer(answer);
//            Assert.AreEqual(answer, testValidAnswer);
//        }

//        [TestMethod]
//        public void CheckWrongAnswerSudokuTest()
//        {
//            string answer = "n";
//            string expectedReturnValue = "Not right input";
//            var testValidAnswer = sudokuBoardDisplayer.CheckAnswer(answer);
//            Assert.AreSame(answer, testValidAnswer);
//        }

        //[TestMethod]
        //public void SelectWrongSudokuBoard(int sudoku)
        //{
        //    var wrongSudoku = sudokuBoardDisplayer.SelectSudokuBoard(sudoku);
        //    Assert.That(() => wrongSudoku, Throws.Exception);
        //    // Assert.That(() => wrongMap, Throws.Exception);
        //}


    }
}
