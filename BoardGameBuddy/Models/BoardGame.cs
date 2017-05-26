using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameBuddy.Models
{
    public class BoardGame
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public string PlayerCount { get; set; }
        public int BestPlayerCount { get; set; }
        public int PlayTimeMax { get; set; }
        public int MaRating { get; set; }
        public int GeekRating { get; set; }
    }
}