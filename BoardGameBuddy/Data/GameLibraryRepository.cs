using BoardGameBuddy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameBuddy.Data
{
   
    //void addGame(int Id) -  Adds game to List from using BoardGame.Id (easiest way for now, no need to fuck with string searches just yet)
    //void removeGame(int Id) - removes desired BoardGame from List
    //void clearLibrary() - removes all BoardGame objects from arrayList

    public class GameLibraryRepository
    {
        //! Constructor: create empty ArrayList
        //private static ArrayList _GameLibrary = new ArrayList(new BoardGame[] { });

        //! Constructor v2: Adds all BoardGames in BoardgameRepository
        private static List<BoardGame> _GameLibrary = new List<BoardGame>()
        {
            //empty
        };
     


    }
}