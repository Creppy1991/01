using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public int GenreID { get; set; }
        public string GameTitle { get; set; }
        public string GameStudio { get; set; }
        public DateTime DateAdded { get; set; }
        public string GameDescription { get; set; }
        public decimal GamePrice { get; set; }
        public bool GamePromotion { get; set; }
        public bool GameIsHidden { get; set; }
        public virtual Genre Genre { get; set; }
    }
}