using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ChessTools
{
    /// <summary>
    /// Class that defines a PGN Reader Object for processing and storing chess games
    /// Author: Pranav Rajan
    /// Date: March 1, 2020
    /// </summary>
    public static class PGNReader
    {
        /// <summary>
        /// Reads in data from a PGN file and creates Chess Game Objects
        /// </summary>
        /// <param name="FilePath">The path of the PGN File</param>
        /// <returns>List of chess games</returns>
        public static List<ChessGame>GenerateChessGames(String filePath)
        {
            // List for storing all the chess games
            List<ChessGame> ChessGames = new List<ChessGame>();
            String[] file = File.ReadAllLines(filePath);

            // Variables that store information for the different parts of a game
            // The String type was chosen to represent all the data to based on the types for the different 
            // tables. For types that need further processing, that is handled in the Chess Game Class

            // Represents the name of the event
            String Event = "";
            // Represents the site of the event
            String Site = "";
            // Represents a round
            String Round = "";
            // Represents the white player name
            String WhitePlayer = "";
            // Represents the black player name
            String BlackPlayer = "";
            // Represents the white player ELO ranking
            String WhiteElo = "";
            // Represents the black player ELO ranking
            String BlackElo = "";
            // Represents the result of a game
            String Result = "";
            // Represents the date of an event
            String EventDate = "";
            // Represents the number of moves
            String Moves = "";
            // Counter for keeping track of blank lines for identifying where moves are located and when to start a new game
            int BlankLineCounter = 0;

            for (int LineNumber = 0; LineNumber < file.Length; LineNumber++)
            {
                String CurrentLine = file[LineNumber];

                // CASE 1: EVENTS
                if (CurrentLine.StartsWith("[Event "))
                {
                    //int thing = CurrentLine.IndexOf("Event");
                    int StartIndex = CurrentLine.IndexOf(' ') + 2;
                    int Length = CurrentLine.Length - 2 - StartIndex;
                    Event = CurrentLine.Substring(StartIndex, Length);
                }
                // CASE 2: SITE
                else if (CurrentLine.StartsWith("[Site"))
                {
                    int StartIndex = CurrentLine.IndexOf(' ') + 2;
                    int Length = CurrentLine.Length - 2 - StartIndex;
                    Site = CurrentLine.Substring(StartIndex, Length);
                }
                // CASE 3: ROUND
                else if (CurrentLine.StartsWith("[Round"))
                {
                    int StartIndex = CurrentLine.IndexOf(' ') + 2;
                    int Length = CurrentLine.Length - 2 - StartIndex;
                    Round = CurrentLine.Substring(StartIndex, Length);
                }
                // CASE 4: WHITE PLAYER
                else if (CurrentLine.StartsWith("[White "))
                {
                    int StartIndex = CurrentLine.IndexOf(' ') + 2;
                    int Length = CurrentLine.Length - 2 - StartIndex;
                    WhitePlayer = CurrentLine.Substring(StartIndex, Length);
                }
                // CASE 5: BLACK PLAYER
                else if (CurrentLine.StartsWith("[Black "))
                {
                    int StartIndex = CurrentLine.IndexOf(' ') + 2;
                    int Length = CurrentLine.Length - 2 - StartIndex;
                    BlackPlayer = CurrentLine.Substring(StartIndex, Length);
                }
                // CASE 6: RESULT
                else if (CurrentLine.StartsWith("[Result"))
                {
                    int StartIndex = CurrentLine.IndexOf(' ') + 2;
                    int Length = CurrentLine.Length - 2 - StartIndex;
                    Result = CurrentLine.Substring(StartIndex, Length);

                    // CASE 1: DRAW
                    if (Result.Equals("1/2-1/2"))
                    {
                        Result = "D";
                    }
                    // CASE 2: BLACK WINS
                    else if (Result.Equals("0-1"))
                    {
                        Result = "B";
                    }
                    // CASE 3: WHITE WINS
                    else
                    {
                        Result = "W";
                    }
                }
                // CASE 7: WHITE ELO RANK
                else if (CurrentLine.StartsWith("[WhiteElo"))
                {
                    int StartIndex = CurrentLine.IndexOf(' ') + 2;
                    int Length = CurrentLine.Length - 2 - StartIndex;
                    WhiteElo = CurrentLine.Substring(StartIndex, Length);
                }
                // CASE 8: BLACK ELO RANK
                else if (CurrentLine.StartsWith("[BlackElo"))
                {
                    int StartIndex = CurrentLine.IndexOf(' ') + 2;
                    int Length = CurrentLine.Length - 2 - StartIndex;
                    BlackElo = CurrentLine.Substring(StartIndex, Length);
                }
                // CASE 9:EVENT DATE
                else if (CurrentLine.StartsWith("[EventDate"))
                {
                    int StartIndex = CurrentLine.IndexOf(' ') + 2;
                    int Length = CurrentLine.Length - 2 - StartIndex;
                    EventDate = CurrentLine.Substring(StartIndex, Length);
                }
                // CASE 10: BLANK LINES AND MOVES
                else
                {
                    if (CurrentLine.Length == 0)
                    {
                        BlankLineCounter++;
                        //continue;
                    }
                    if (BlankLineCounter == 1)
                    {
                        Moves += CurrentLine;
                    }
                    if (BlankLineCounter > 1)
                    {
                        // Create a new game and add it to the list of games
                        ChessGame NewGame = new ChessGame(Event, Site, Round, WhitePlayer, BlackPlayer, WhiteElo, BlackElo, Result, EventDate, Moves);
                        ChessGames.Add(NewGame);

                        // Reset all values for processing next game
                        Event = "";
                        Site = "";
                        Round = "";
                        WhitePlayer = "";
                        BlackPlayer = "";
                        WhiteElo = "";
                        BlackElo = "";
                        Result = "";
                        EventDate = "";
                        Moves = "";
                        BlankLineCounter = 0;
                    }
                }
            }
            return ChessGames;
        }
    }
}
