using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LetUsPlay.Models
{
    public class Game
    {
       
        public int Id { get; set; }

        public string  GameName { get; set; }

        public DateTime GameStartTime { get; set; }

        public DateTime GameEndTime { get; set; }

        public int NumberOfPlayers { get; set; }
        
        public Location Location { get; set; }

        public ICollection<Playing> Playings { get; set; }
    }
}