using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;
using System;

namespace SudokuTests
{
    [TestClass]
    public class SudokuMapTest
    {

        //static int[,]  testBoard = new int[,] {
        //        { 3, 0, 6, 5, 0, 8, 4, 0, 0 },
        //        { 5, 2, 0, 0, 0, 0, 0, 0, 0 },
        //        { 0, 8, 7, 0, 0, 0, 0, 3, 1 },
        //        { 0, 0, 3, 0, 1, 0, 0, 8, 0 },
        //        { 9, 0, 0, 8, 6, 3, 0, 0, 5 },
        //        { 0, 5, 0, 0, 9, 0, 6, 0, 0 },
        //        { 1, 3, 0, 0, 0, 0, 2, 5, 0 },
        //        { 0, 0, 0, 0, 0, 0, 0, 7, 4 },
        //        { 0, 0, 5, 2, 0, 6, 3, 0, 0 }
        //    };

        //static int[,] testBoard2 = new int[,] {
        //        { 3, 0, 6, 5, 0, 8, 4, 0, 0 },
        //        { 5, 2, 0, 0, 0, 0, 0, 0, 0 },
        //        { 0, 8, 7, 0, 0, 0, 0, 3, 1 },
        //        { 0, 0, 3, 0, 1, 0, 0, 8, 0 },
        //        { 9, 0, 0, 8, 6, 3, 0, 0, 5 },
        //        { 0, 5, 0, 0, 9, 0, 6, 0, 0 },
        //        { 1, 3, 0, 0, 0, 0, 2, 5, 0 },
        //        { 0, 0, 0, 0, 0, 0, 0, 7, 4 },
        //    };

        //static int[,] testBoard3 = new int[,] {
        //        { 3, 0, 6, 5, 0, 8, 4, 0 },
        //        { 5, 2, 0, 0, 0, 0, 0, 0 },
        //        { 0, 8, 7, 0, 0, 0, 0, 3},
        //        { 0, 0, 3, 0, 1, 0, 0, 8 },
        //        { 9, 0, 0, 8, 6, 3, 0, 0 },
        //        { 0, 5, 0, 0, 9, 0, 6, 0 },
        //        { 1, 3, 0, 0, 0, 0, 2, 5 },
        //        { 0, 0, 0, 0, 0, 0, 0, 7 },
        //    };

        //static int[,] testBoard4 = new int[,] {
        //        { 13, 0, 6, 5, 0, 8, 4, 0, 0 },
        //        { 5, 2, 0, 0, 0, 0, 0, 0, 0 },
        //        { 0, 8, 7, 0, 0, 0, 0, 3, 1 },
        //        { 0, 0, 3, 0, 1, 0, 0, 8, 0 },
        //        { 9, 0, 0, 8, 6, 3, 0, 0, 5 },
        //        { 0, 5, 0, 0, 9, 0, 6, 0, 0 },
        //        { 1, 3, 0, 0, 0, 0, 2, 5, 0 },
        //        { 0, 0, 0, 0, 0, 0, 0, 7, 4 },
        //        { 0, 0, 5, 2, 0, 6, 3, 0, 0 }
        //    };

        //SudokuLogic solver = new SudokuLogic();
        //SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();


        //[TestMethod]
        //public void GenerateMap()
        //{
        //    int maxNumber = testBoard.GetLength(0);
        //    string answer = "y";
        //    var testGenerateBoard = sudokuBoardDisplayer.generateBoard(testBoard, maxNumber, answer);
        //    Assert.IsTrue(testGenerateBoard);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void CheckTheMaxDepthOfBoard()
        //{
        //    int maxNumber = 14;
        //    string answer = "y";
        //    sudokuBoardDisplayer.generateBoard(testBoard, maxNumber, answer);
        //    //var ex  = Assert.ThrowsException<IndexOutOfRangeException>(() => testMaxDepth);
        //    //Assert.AreEqual("maxNumber cannot be bigger than 9 or less than 1", ex.Message);
        //}

        //[TestMethod]
        //public void DeclineGenerateMap()
        //{
        //    int maxNumber = testBoard.GetLength(0);
        //    string answer = "n";
        //    sudokuBoardDisplayer.generateBoard(testBoard, maxNumber, answer);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void CheckBoardMapIfColumnsAreLessThan9()
        //{
        //    int maxNumber = testBoard.GetLength(0);
        //    string answer = "y";
        //    sudokuBoardDisplayer.generateBoard(testBoard3, maxNumber, answer);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void CheckBoardMapIfRowssAreLessThan9()
        //{
        //    int maxNumber = testBoard.GetLength(0);
        //    string answer = "y";
        //    sudokuBoardDisplayer.generateBoard(testBoard2, maxNumber, answer);
        //}
    }
}
