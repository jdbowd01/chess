using System;
using System.Collections.Generic;
using Chess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Piece> endPieces = ChessBoard.Chess960Setup();
            Assert.AreEqual(8, endPieces.Count);
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<Piece> endPieces = ChessBoard.Chess960Setup();
            int first = endPieces.IndexOf(Piece.BISHOP);
            int last = endPieces.LastIndexOf(Piece.BISHOP);
            Assert.AreNotEqual(first % 2, last % 2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            List<Piece> endPieces = ChessBoard.Chess960Setup();
            int first = endPieces.IndexOf(Piece.ROOK);
            int last = endPieces.LastIndexOf(Piece.ROOK);
            int king = endPieces.IndexOf(Piece.KING);
            Assert.IsTrue(first < king && king < last);
        }
        [TestMethod]
        public void TestMethod4()
        {
            List<Piece> endPieces = ChessBoard.Chess960Setup();
            int firstR = endPieces.IndexOf(Piece.ROOK);
            int lastR = endPieces.LastIndexOf(Piece.ROOK);
            int firstK = endPieces.IndexOf(Piece.KNIGHT);
            int lastK = endPieces.LastIndexOf(Piece.KNIGHT);
            int firstB = endPieces.IndexOf(Piece.BISHOP);
            int lastB = endPieces.LastIndexOf(Piece.BISHOP);
            Assert.IsTrue(endPieces.Contains(Piece.KING) && endPieces.Contains(Piece.QUEEN) && firstB != lastB && firstK != lastK && firstR != lastR);
        }
        //[TestMethod]
        //public void TestMethod5()
        //{
        //    List<Piece> endPieces = ChessBoard.Chess960Setup();
        //    Assert.AreEqual(8, endPieces.Count);
        //}
    }
}
