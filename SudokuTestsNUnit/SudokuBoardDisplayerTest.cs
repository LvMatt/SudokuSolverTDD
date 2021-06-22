using NUnit.Framework;
using Sudoku;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuTestsNUnit
{
    public class SudokuBoardDisplayerTest
    {
        // Local function ARRANGE

        SudokuLogic solver = new SudokuLogic();
        SudokuBoards sudokuBoards = new SudokuBoards();
        SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();



        [Test]
        public void CheckTheMaxDepthOfBoard()
        {

            // ARRANGE 
            int maxNumber = 14;

            // ACT AND ASSERT COMBINED

            Assert.That(() => sudokuBoardDisplayer.generateBoard(sudokuBoards.easyBoard, maxNumber), Throws.Exception);

        }



        [Test]
        public void GenerateMap()
        {
            // ARRANGE 
            SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();
            int maxNumber = sudokuBoards.easyBoard.GetLength(0);

            // ACT 

            var testGenerateBoard = sudokuBoardDisplayer.generateBoard(sudokuBoards.easyBoard, maxNumber);

            // ASSERT 
            Assert.IsTrue(testGenerateBoard);
        }

        // Improve

        [Test]
        public void CheckLengthOfBoardMapIfRowAreLessThan1()
        {
            // ARRANGE

            int maxNumber = sudokuBoards.testBoard2.GetLength(0);

            // ACT

            var result = sudokuBoardDisplayer.generateBoard(sudokuBoards.easyBoard, maxNumber);
            
            // ASSERT 

            Assert.IsTrue(result);

        }

        [Test]
        public void CheckLengthOfBoardMapIColAreLessThan9AndReturnTrue()
        {
            // ARRANGE

            int maxNumber = sudokuBoards.testBoard3.GetLength(0);

            // ACT

            var result = sudokuBoardDisplayer.generateBoard(sudokuBoards.easyBoard, maxNumber);

            // ASSERT 

            Assert.IsTrue(result);

        }

        [Test]
        public void CheckInsideBoardMapIfColumnsAreLessThan9InsideBoard()
        {
            // ARRANGE 

            int maxNumber = sudokuBoards.easyBoard.GetLength(0);

            // ACT AND ASSERT COMBINED

            Assert.That(() => sudokuBoardDisplayer.generateBoard(sudokuBoards.testBoard3, maxNumber), Throws.Exception);
        }

        [Test]
        public void CheckInsideBoardMapIfRowssAreLessThan9()
        {
            // ARRANGE 
            int maxNumber = sudokuBoards.easyBoard.GetLength(0);

            // ACT AND ASSERT COMBINED

            Assert.That(() => sudokuBoardDisplayer.generateBoard(sudokuBoards.testBoard2, maxNumber), Throws.Exception);

            //var ex = Assert.Throws<Exception>(() => sudokuBoardDisplayer.generateBoard(sudokuBoards.testBoard2, maxNumber, answer));
            //Assert.That(ex.Message, Is.EqualTo("Index was outside the bounds of the array"));
            // Assert.That(() => wrongMap, Throws.Exception);
        }


       
    }
}
