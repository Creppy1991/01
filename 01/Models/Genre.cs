using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public int GenreDescription { get; set; }
        public int GenreIconFileName { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}