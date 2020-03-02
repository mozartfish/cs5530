using System;

namespace ChessTools
{
    /// <summary>
    /// A class library that defines Chess Objects for use in the Chess Database
    /// Author: Pranav Rajan
    /// Date: February 29, 2020
    /// </summary>
    public class ChessGame
    {
        /// <summary>
        /// The event name
        /// </summary>
        private String Event;
        /// <summary>
        /// The event site
        /// </summary>
        private String Site;
        /// <summary>
        /// The round in which the game took place. Not always convertible to a number since it can also have decimals
        /// </summary>
        private String Round;
        /// <summary>
        /// The name of the white player
        /// </summary>
        private String WhitePlayer;
        /// <summary>
        /// The name of the black player
        /// </summary>
        private String BlackPlayer;
        /// <summary>
        /// The white player's ELO rating at the time of the game
        /// </summary>
        private Int32 WhiteElo;
        /// <summary>
        /// The black player's ELO rating at the time of the game
        /// </summary>
        private Int32 BlackElo;
        /// <summary>
        /// The result of the game
        /// </summary>
        private String Result;
        /// <summary>
        /// The event date which is the date of the game
        /// </summary>
        private String EventDate;
        /// <summary>
        /// The text that represents the moves. Always comes after a blank line following the above tagged data
        /// </summary>
        private String Moves;

        /// <summary>
        /// Constructor for the Chess Game Object
        /// </summary>
        /// <param name="Event">The event name</param>
        /// <param name="Site">The event site</param>
        /// <param name="Round">The round in which the game took place</param>
        /// <param name="WhitePlayer">The name of the white player</param>
        /// <param name="BlackPlayer">The name of the black player</param>
        /// <param name="WhiteElo">The ELO ranking of the white player</param>
        /// <param name="BlackElo">The ELO ranking of the black player</param>
        /// <param name="Result">The result of the game</param>
        /// <param name="EventDate">The event date</param>
        /// <param name="Moves">The moves the players made during the game</param>
        public ChessGame(String Event, String Site, String Round, String WhitePlayer, String BlackPlayer, String WhiteElo, String BlackElo, String Result, String EventDate, String Moves)
        {
            this.Event = Event;
            this.Site = Site;
            this.Round = Round;
            this.WhitePlayer = WhitePlayer;
            this.BlackPlayer = BlackPlayer;

            // Convert the ELO Rank to Integer Based on the Players and Event Table Specs
            this.WhiteElo = Int32.Parse(WhiteElo);
            this.BlackElo = Int32.Parse(BlackElo);

            this.Result = Result;
            this.EventDate = EventDate;
            this.Moves = Moves;
        }

        /// <summary>
        /// Returns the name of the event
        /// </summary>
        public String getEvent { get => this.Event;}
        /// <summary>
        /// Returns the site
        /// </summary>
        public String getSite { get => this.Site; }
        /// <summary>
        /// Returns the round
        /// </summary>
        public String getRound { get => this.Round; }
        /// <summary>
        /// Returns the name of the white player
        /// </summary>
        public String getWhitePlayer { get => this.WhitePlayer; }
        /// <summary>
        /// Returns the name of the black player
        /// </summary>
        public String getBlackPlayer { get => this.BlackPlayer; }
        /// <summary>
        /// Returns the  ELO Rank of the black player
        /// </summary>
        public int getBlackElo { get => this.BlackElo; }
        /// <summary>
        /// Returns the ELO Rank of the White Player
        /// </summary>
        public int getWhiteElo { get => this.WhiteElo; }
        /// <summary>
        /// Returns the result of the Game
        /// If the score is "W" then White won
        /// If the score is "B" then Black won
        /// If the score is "D" then there is a draw
        /// </summary>
        public String getResult { get => this.Result; }
        /// <summary>
        /// Returns the event data
        /// </summary>
        public String getEventDate { get => this.EventDate; }
        /// <summary>
        /// Returns the moves in the game
        /// </summary>
        public String getMoves { get => this.Moves; }
    }
}