using BoardGameBuddy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//this BoardGameRepository will hold BoardGame data

namespace BoardGameBuddy.Data
{
    public class BoardGameRepository
    {
        
        private static BoardGame[] _boardGames = new BoardGame[]
        {
            new BoardGame()
            {
                Id = 1,
                Title = "Blood Rage",
                PlayerCountMin = 2,
                PlayerCountMax = 5,
                BestPlayerCount = 4,
                PlayTimeMax = 90,
                MyRating = 7.5,
                GeekRating = 8.2,
            },
            new BoardGame()
            {
                Id = 2,
                Title = "Lost Citiese",
                PlayerCountMin = 2,
                PlayerCountMax = 2,
                BestPlayerCount = 2,
                PlayTimeMax = 30,
                MyRating = 8.1,
                GeekRating = 7.1,
            },
            new BoardGame()
            {
                Id = 3,
                Title = "Dead of Winter: A Crossroads Game ",
                PlayerCountMin = 2,
                PlayerCountMax = 5,
                BestPlayerCount = 4,
                PlayTimeMax = 210,
                MyRating = 7.5,
                GeekRating = 7.9,
            },
            new BoardGame()
            {
                Id = 4,
                Title = "Cosmic Encounter",
                PlayerCountMin = 3,
                PlayerCountMax = 6,
                BestPlayerCount = 5,
                PlayTimeMax = 120,
                MyRating = 9.0,
                GeekRating = 7.6,
            },
            new BoardGame()
            {
                Id = 5,
                Title = "Codenames",
                PlayerCountMin = 2,
                PlayerCountMax = 8,
                BestPlayerCount = 6,
                PlayTimeMax = 15,
                MyRating = 8,
                GeekRating = 7.9,
            }
        };  //end array

        public BoardGame[] GetBoardGames()
        //!
        //!
        {
            return _boardGames;
        }


        //-----------------------------------------------------------------------

        public BoardGame GetBoardGame(int id)
        //!
        //!
        {
            BoardGame boardGameToReturn = null;

            foreach (var boardGame in _boardGames)
            {
                if (boardGame.Id == id)
                {
                    boardGameToReturn = boardGame;
                    break;
                }
            }

            return boardGameToReturn;
        }


    }
}