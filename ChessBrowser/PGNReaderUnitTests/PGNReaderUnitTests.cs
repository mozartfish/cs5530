using System;
using System.Collections.Generic;
using ChessTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PGNReaderUnitTests
{
    [TestClass]
    public class PGNReaderUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            String filePath = @"C:\Users\rajan\Desktop\cs_work\cs5530\ChessBrowser\kb1.pgn";
            List<ChessGame> thing = PGNReader.GenerateChessGames(filePath);
            Assert.IsTrue(thing.Count == 0);
        }
    }
}


