using NUnit.Framework;
using Sudoku;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuTestsNUnit
{
    [TestFixture]
    class SudokuValidationTest
    {
        // Local function ARRANGE

        SudokuLogic solver = new SudokuLogic();
        SudokuBoards sudokuBoards = new SudokuBoards();
        SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();
        int row = 1;
        int col = 1;
        int num = 1;

        [Test]
        [TestCase(1)]
        public void ValidatorWrapperReturnsFalseForFirstNumberInCol0AndRow0(int num)
        {
            // ARRANGE 

            int col = 0;
            int row = 0;

            // ACT 

            var sudokuBoard = sudokuBoards.easyBoard;

            // ASSERT

            var wrapper = solver.validatorWrapper(sudokuBoard, col, row, num);
            Assert.IsFalse(wrapper);
        }

        [Test]
        [TestCase(8)]
        public void ValidatorWrapperReturnsTrueForFirstNumberInCol0AndRow0(int num)
        {
            // ARRANGE 

            int col = 0;
            int row = 0;
            var sudokuBoard = sudokuBoards.easyBoard;

            // ACT 

            var wrapper = solver.validatorWrapper(sudokuBoard, col, row, num);
            
            // ASSERT 

            Assert.IsTrue(wrapper);
        }

        [Test]
        [TestCase(10)]
        public void RowParameterAboveRange(int row)
        {
            Assert.That(() => solver.rowValidator(sudokuBoards.easyBoard, col, row, num), Throws.Exception);
        }

        [Test]
        [TestCase(1)]
        public void RowParameterWrongNumberReturnFalse(int row)
        {
            // ARRANGE 

            int col = 1;
            int num = 1;

            //ACT 

            var validatorFunc = solver.rowValidator(sudokuBoards.easyBoard, col, row, num);

            //ASERT 

            Assert.IsFalse(validatorFunc);
        }

        [Test]
        [TestCase(1)]
        public void ColParameterCorrectNumberReturnTrue(int col)
        {
            // ARRANGE 

            int row = 1;
            int num = 3;

            // ACT 

            var validatorFunc = solver.colValidator(sudokuBoards.easyBoard, col, row, num);

            // ASSERT 

            Assert.IsTrue(validatorFunc);
        }


        [Test]
        [TestCase(1)]
        public void ColParameterWrongNumberReturnFalse(int col)
        {
            // ARRANGE 

            int row = 1;
            int num = 4;

            //ACT 

            var validatorFunc = solver.colValidator(sudokuBoards.easyBoard, col, row, num);

            //ASERT 

            Assert.IsFalse(validatorFunc);
        }

        [Test]
        [TestCase(1)]
        public void GroupParameterCorrectNumberReturnTrue(int col)
        {
            // ARRANGE 

            int row = 0;
            int num = 5;

            // ACT 

            var validatorFunc = solver.colValidator(sudokuBoards.easyBoard, col, row, num);

            // ASSERT 

            Assert.IsTrue(validatorFunc);
        }


        [Test]
        [TestCase(1)]
        public void GroupParameterWrongNumberReturnFalse(int col)
        {
            // ARRANGE 

            int row = 0;
            int num = 6;

            //ACT 

            var validatorFunc = solver.groupValidator(sudokuBoards.easyBoard, col, row, num);

            //ASERT 

            Assert.IsFalse(validatorFunc);
        }



        [Test]
        [TestCase(0)]
        public void RowParameterCorrectNumberReturnTrue(int row)
        {
            // ARRANGE 

            int col = 0;
            int num = 8;

            // ACT 

            var validatorFunc = solver.rowValidator(sudokuBoards.easyBoard, col, row, num);

            // ASSERT 

            Assert.IsTrue(validatorFunc);
        }





        [Test]
        [TestCase(10)]
        public void ColParameterAboveRange(int colCurrent)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => solver.colValidator(sudokuBoards.easyBoard, colCurrent, row, num), Throws.Exception);
        }

        [Test]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        public void IndexParameterAboveRange(int num)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => solver.groupValidator(sudokuBoards.easyBoard, col, row, num), Throws.Exception);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(-3)]
        public void RowParameterBelowRange(int row)
        {
            // ARRANGE 
            SudokuLogic solver = new SudokuLogic();
            SudokuBoards sudokuBoards = new SudokuBoards();
            int maxNumber = 9;
            int col = 1;
            int num = 1;

            // ACT AND ASSERT COMBINED

            Assert.That(() => solver.rowValidator(sudokuBoards.easyBoard, col, row, num), 
                Throws.Exception);
        }

        [Test]
        [TestCase(-1)]
        public void ColParameterBelowRange(int colCurrent)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => solver.colValidator(sudokuBoards.easyBoard, colCurrent, row, num), Throws.Exception);
        }

        [Test]
        [TestCase(-1)]
        public void IndexParameterBelowRange(int num)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => solver.groupValidator(sudokuBoards.easyBoard, col, row, num), Throws.Exception);
        }

        [Test]
        [TestCase(-3)]
        public void ColParameterNegativeRange(int col)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => solver.colValidator(sudokuBoards.easyBoard, col, row, num), Throws.Exception);
        }

        [Test]
        [TestCase(-3)]
        public void RowarameterNegativeRange(int row)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => solver.rowValidator(sudokuBoards.easyBoard, col, row, num), Throws.Exception);
        }

        [Test]
        [TestCase(-3)]
        public void IndexParameterNegativeRange(int num)
        {
            // ACT AND ASSERT COMBINED

            Assert.That(() => solver.groupValidator(sudokuBoards.easyBoard, col, row, num), Throws.Exception);
        }
    }
}
