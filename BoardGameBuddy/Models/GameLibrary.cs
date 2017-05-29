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
        //! Adds every BoardGame in BoardGamerepository to GameLibrary
        {
            foreach (BoardGame game in repo)
            {
                gameLibrary.Add(game);
            }
        }

        
        public void clearGames()
        //! Removes all games from Library
        {
            gameLibrary.Clear();
        }

        public void addIndex(List<BoardGame> fromRepository, int index)
        //! Actually adds based on index of fromRepository(cheat for now) 
        //! adds BoardGame to gameLibrary using BoardGame.Id (as of now Id == (Index-1)
        //! not actually searching for Id:(
        {
            BoardGame newGame = new BoardGame();
            newGame = fromRepository[index];
            gameLibrary.Add(newGame);     
        }

        public void removeAt(int index)
        //! just overloading Class.List Method....pretty sure this is redundant.
        //! removes BoardGame from gameLibrary by index
        //! not actually searching for Id:(
        {   
            gameLibrary.RemoveAt(index);
        }


    }
}