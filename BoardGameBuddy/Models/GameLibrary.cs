using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameBuddy.Models
{
    public class GameLibrary : List<BoardGame>
    {
        public List<BoardGame> gameLibrary;

        public GameLibrary()
        {
           gameLibrary = new List<BoardGame>();
        }


        public List<BoardGame> GetBoardGames()
        //! returns the gameLibrary created upon construction
        //! Used for passing to views
        {
            return gameLibrary;
        }//End GetBoardGames


        public BoardGame GetBoardGame(int id)
        {
            BoardGame gameToReturn = null;

            foreach (var game in gameLibrary)
            {
                if (game.Id == id)
                {
                    gameToReturn = game;
                    break;
                }
            }
            return gameToReturn;
        }//End GetBoardGame

        public void addAll(List<BoardGame> repo)
        //! Adds every BoardGame in availableGames to GameLibrary
        {
            foreach (BoardGame game in repo)
            {
                gameLibrary.Add(game);
            }
        }//end AddAll

        //public void addAll(List<BoardGame> allGames)
        //{
        //    for (int i = 0; i < allGames.Count; i++)
        //    {
        //      gameLibrary = allGames;
        //    }
        //}

    }
}