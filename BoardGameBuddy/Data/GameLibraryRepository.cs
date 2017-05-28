﻿using BoardGameBuddy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameBuddy.Data
{
    public class GameLibraryRepository
    {
        public static List<BoardGame> GameLibrary;//! Users Library
        public BoardGameRepository _gamesToAddFrom;//! Creates new B.G.R.
        public List<BoardGame> availableGames;//! Holds contents of _gamesToAddFrom.boardGames

        //! construictor
        public GameLibraryRepository()
        {
            GameLibrary = new List<BoardGame>();
            _gamesToAddFrom = new BoardGameRepository();
            availableGames = _gamesToAddFrom.GetBoardGames();
        }//endConstructor


        public void addAll()
        //! Adds every BoardGame in availableGames to GameLibrary
        {
            foreach (BoardGame game in availableGames)
            {
                GameLibrary.Add(game);
            }
        }//end AddAll


       
        public BoardGame GetBoardGame(int id)
        //! retrivies each game in List for View Purposes 
        {
            BoardGame boardGameToReturn = null;

            foreach (var boardGame in availableGames)
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



