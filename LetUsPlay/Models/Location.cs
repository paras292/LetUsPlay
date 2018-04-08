using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LetUsPlay.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public ICollection<Game> Game { get; set; }

        public ICollection<Playing> Playings { get; set; }
    }
}