using NUnit.Framework;
using Sudoku;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuTestsNUnit
{
    [TestFixture]
    class SudokuControlsTest
    {

        // Local function ARRANGE

        SudokuLogic solver = new SudokuLogic();
        SudokuBoards sudokuBoards = new SudokuBoards();
        SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();
        
        int maxNumber = 9;
        int row = 1;
        int col = 1;
        int num = 1;


        // RUN SUDOKU FUNCTION

        [Test]
        public void RunSudokuTestPass()
        {
            // ACT

            var testRunSudoku = solver.runSudoku(sudokuBoards.easyBoard);
           
            // ASSERT

            if (testRunSudoku)
                Assert.IsTrue(testRunSudoku);
        }

        // Problem test
        [Test]
        public void RunSudokuTestFail()
        {
            // ACT

            var testRunSudoku = solver.runSudoku(sudokuBoards.easyBoardWrong);
            
            // ASSERT

            Assert.IsFalse(testRunSudoku);
        }

        [Test]
        public void RunWrongSudoku()
        {
            // ACT 

            var wrongSudokuBoard = sudokuBoards.wrongSudokuBoard;
            
            // ASSERT

            Assert.That(() => solver.runSudoku(wrongSudokuBoard), Throws.Exception);
        }

        // C H E C K   A N S W E R    F U N C T I O N S

        [Test]
        public void CheckRightAnswerSudokuTest()
        {

            // ARRANGE

            var answer = "y";

            // ACT

            var testValidAnswer = sudokuBoardDisplayer.CheckAnswer(answer);
           
            //ACT

            Assert.IsTrue(testValidAnswer.Contains(answer));
        }

        [Test]
        public void CheckWrongAnserSudokuTest()
        {
            // ARRANGE


            string answer = "n";
            string expectedReturnValue = String.Empty;
            
            // ACT

            var testValidAnswer = sudokuBoardDisplayer.CheckAnswer(answer);
            
            // ASSERT

            Assert.IsTrue(testValidAnswer.Contains(expectedReturnValue));
        }

        // S E L E C T    S U D O K U    B O A R D S    F U N C T I O N S
        [Theory]
        [TestCase(4)]
        public void SelectWrongSudokuBoardAboveRange(int sudoku)
        {

            // ACT AND ASSERT COMBINED

            Assert.Throws<Exception>(() => sudokuBoardDisplayer.SelectSudokuBoard(sudoku)); 
        }

        [Test]
        [TestCase(0)]
        public void SelectWrongSudokuBoardBelowRange(int sudoku)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => sudokuBoardDisplayer.SelectSudokuBoard(sudoku), Throws.Exception);
        }

        [Test]
        [TestCase(null)]
        public void SelectWrongSudokuBoardNullException(int sudoku)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => sudokuBoardDisplayer.SelectSudokuBoard(sudoku), Throws.Exception);
        }


    }
}
