using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTools
{
    /// <summary>
    /// Class that defines a PGN Reader Object for processing and storing chess games
    /// </summary>
    public class PGNReader
    {
        /// <summary>
        /// Function that generates chess games from a PGN File
        /// </summary>
        /// <param name="FilePath">The path of the PGN File</param>
        /// <returns>List of chess games</returns>
        public List<ChessGame> GenerateChessGames(String FilePath)
        {
            List<ChessGame> chessGames = new List<ChessGame>();
            return chessGames;
        }
    }
}
