using System;
using System.Collections.Generic;
using ChessTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PGNReaderUnitTests
{
    /// <summary>
    /// Class that tests the PGN Reader
    /// </summary>
    [TestClass]
    public class PGNReaderUnitTests
    {
        [TestMethod]
        public void TestKB1()
        {
            String filePath = @"C:\Users\rajan\Desktop\cs_work\cs5530\ChessBrowser\kb1.pgn";
            List<ChessGame> thing = PGNReader.GenerateChessGames(filePath);
            ChessGame first = thing[0];
            Assert.IsTrue(first.getEvent.Equals("4. IIFL Wealth Mumbai Op"));
            Assert.IsTrue(first.getSite.Equals("Mumbai IND"));
            Assert.IsTrue(first.getRound.Equals("2.9"));
            Assert.IsTrue(first.getWhitePlayer.Equals("Sundararajan, Kidambi"));
            Assert.IsTrue(first.getBlackPlayer.Equals("Ziatdinov, Raset"));
            Assert.IsTrue(first.getResult.Equals("D"));
            Assert.IsTrue(first.getWhiteElo == 2458);
            Assert.IsTrue(first.getBlackElo == 2252);
            Assert.IsTrue(first.getEventDate.Equals("2018.12.30"));
            Assert.IsTrue(first.getMoves.Equals("1.c4 e5 2.Nc3 Nc6 3.e3 Nf6 4.a3 Be7 5.Nf3 O-O 6.Be2 d6 7.d4 exd4 8.Nxd4 Nxd4 9.Qxd4 Be6 10.Nd5 c5 11.Nxe7+ Qxe7 12.Qh4 d5 13.cxd5 Bxd5 14.f3 Qe6 15.O-O Nd7 16.Bd2 f5 17.Rac1 Rac8 18.Rfe1 Ne5 19.Bc3 Ng6 20.Qf2 Bb3 21.Bf1a6 22.Qg3 Qe7 23.Bd3 Rc6 24.Qf2 Re6 25.g3 h5 26.h4 b5 27.f4 Bd5 28.Be2 Kf729.Bxh5 Rh8 30.Rcd1 Bb3 31.Bf3 Bxd1 32.Rxd1 Rd8 33.Rd5 Kg8 34.Rxf5 Rxe3 35.Bd5+ Rxd5 36.Rxd5 Qe4 37.Rd1 Re2 38.Re1 Nxf4 39.Rxe2 Nxe2+ 40.Kh2 Nd4 41.Qf4 Qxf4 42.gxf4 Nc6 43.Kg3 b4 44.Bd2 a5 45.Kf3 c4 46.Ke4 1/2-1/2"));
        }
        [TestMethod]
        public void TestKB2()
        {
            String filePath = @"C:\Users\rajan\Desktop\cs_work\cs5530\ChessBrowser\kb2.pgn";
            List<ChessGame> foo = PGNReader.GenerateChessGames(filePath);
            ChessGame first = foo[0];
            Assert.IsTrue(first.getEvent.Equals("12. Amantea Open 2014"));
            Assert.IsTrue(first.getSite.Equals("Amantea ITA"));
            Assert.IsTrue(first.getRound.Equals("6.9"));
            Assert.IsTrue(first.getWhitePlayer.Equals("Draskovic, Luka"));
            Assert.IsTrue(first.getBlackPlayer.Equals("Valsecchi, Alessio"));
            Assert.IsTrue(first.getResult.Equals("D"));
            Assert.IsTrue(first.getWhiteElo == 2337);
            Assert.IsTrue(first.getBlackElo == 2438);
            Assert.IsTrue(first.getEventDate.Equals("2014.09.07"));
            Assert.IsTrue(first.getMoves.Equals("1.e4 c5 2.Nf3 d6 3.d4 cxd4 4.Nxd4 Nf6 5.f3 g6 6.c4 Nc6 7.Nc3 Nxd4 8.Qxd4 Bg7 9.Be3 O-O 10.Qd2 Qa5 11.Rc1 Be6 12.b3 Nd7 13.Be2 f5 14.exf5 gxf5 15.O-O f4 16.Nd5 Qxd2 17.Bxd2 Bxd5 18.cxd5 Bd4+ 19.Kh1 Bb6 20.Bd3 Ne5 21.Be4 a5 22.g3 fxg3 23.hxg3 a4 24.b4 Rac8 25.Bh6 Rfe8 26.Kg2 Rc4 27.Rxc4 Nxc4 28.Re1 Bd4 29.Bf5 Bf6 30.Be6+ Kh8 31.Bd7 Ra8 32.Rc1 Ne5 33.Bf5 b5 34.Rc7 Rb8 35.g4 Nf7 36.Be3 h5 37.Bg6 Ne5 38.Bxh5 Nc4 39.Bc1 a3 40.Bf7 Kg7 41.Be6Rh8 42.Bf4 Kg6 43.Bf5+ Kf7 44.g5 Be5 45.Bxe5 dxe5 46.Be6+ Kg6 47.Rxe7 Kxg548.Kg3 Rh1 49.Bd7 Rg1+ 50.Kf2 Ra1 51.Bxb5 Nd6 52.Be2 Rxa2 53.Rxe5+ Kf4 54.Re6 Nb5 55.Re4+ Kf5 56.Kg3 Nc3 57.Bc4 Rb2 58.Re6 a2 59.Bd3+ Kg5 60.f4+ Kh561.Re1 Ne2+ 62.Bxe2+ Rxe2 63.Ra1 Kg6 64.Kf3 Rb2 65.Ke4 Kf6 66.Kd4 Rxb4+ 67.Kc5 Rb2 68.Kd6 Kf5 69.Kc7 Rc2+ 70.Kd7 Kxf4 71.d6 Kf5 72.Kd8 Ke6 73.d7 Rd2 74.Re1+ Kf7 75.Rf1+ Ke6 76.Re1+ Kf7 77.Kc7 Rc2+ 78.Kd6 Rd2+ 1/2-1/2"));
        }
        [TestMethod]
        public void TestKB3()
        {
            String filePath = @"C:\Users\rajan\Desktop\cs_work\cs5530\ChessBrowser\kb3.pgn";
            List<ChessGame> foobar = PGNReader.GenerateChessGames(filePath);
            ChessGame first = foobar[0];
            Assert.IsTrue(first.getEvent.Equals("ETCC"));
            Assert.IsTrue(first.getSite.Equals("Crete GRE"));
            Assert.IsTrue(first.getRound.Equals("3"));
            Assert.IsTrue(first.getWhitePlayer.Equals("Cheparinov, Ivan"));
            Assert.IsTrue(first.getBlackPlayer.Equals("Drasko, Milan"));
            Assert.IsTrue(first.getResult.Equals("W"));
            Assert.IsTrue(first.getWhiteElo == 2670);
            Assert.IsTrue(first.getBlackElo == 2557);
            Assert.IsTrue(first.getEventDate.Equals("2007.10.28"));
            Assert.IsTrue(first.getMoves.Equals("1.Nf3 Nf6 2.c4 e6 3.Nc3 Bb4 4.Qc2 O-O 5.a3 Bxc3 6.Qxc3 d6 7.e3 a5 8.b3 Re89.d4 Nc6 10.Bb2 e5 11.d5 Ne7 12.Nd2 b5 13.e4 bxc4 14.Bxc4 Bd7 15.O-O c6 16.dxc6 Bxc6 17.f4 Qb6+ 18.Kh1 Ng6 19.fxe5 dxe5 20.a4 Rad8 21.Rac1 Nf4 22.Bxf7+ Kxf7 23.Nc4 Qd4 24.Nxe5+ Rxe5 25.Qxd4 Rxd4 26.Bxd4 Rxe4 27.Bxf6 1-0"));
        }
    }
}


