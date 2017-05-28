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

       

    }
}