using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameBuddy.Models
{
    public class BoardGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PlayerCountMin { get; set; }
        public int PlayerCountMax { get; set; }
        public int BestPlayerCount { get; set; }
        public int PlayTimeMax { get; set; }    //mins
        public double MyRating { get; set; }
        public double GeekRating { get; set; }
    }
}