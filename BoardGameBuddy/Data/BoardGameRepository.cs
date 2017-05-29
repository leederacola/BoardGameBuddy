using BoardGameBuddy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
 * As of Now BoardGameRepository is a List<> of BoardGame objects.
 * 
 **/

namespace BoardGameBuddy.Data
{
    public class BoardGameRepository
    {
        public List<BoardGame> gameRepository = new List<BoardGame>()
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
                Title = "Lost Cities",
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
        };  //end List

        
        public List<BoardGame> GetBoardGames()
        //! returns the gameRepository created upon BoardGameRepository construction
        //! FOR USE IN LIBRARY VIEW
        {
            return gameRepository;
        }//End GetBoardGames


        public BoardGame GetBoardGame(int id)
        {
            BoardGame gameToReturn = null;

            foreach (var game in gameRepository)
            {
                if (game.Id == id)
                {
                    gameToReturn = game;
                    break;
                }
            }
            return gameToReturn;
        }//End GetBoardGame

    }
}


