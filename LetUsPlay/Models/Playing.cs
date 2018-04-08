using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LetUsPlay.Models
{
    public class Playing
    {
        
        public int ExpectedPlayDuration { get; set; }
        [Key,Column(Order = 0)]
        public int GameId { get; set; }
        [Key, Column(Order = 1)]
        public int LocationId { get; set; }
        [Key, Column(Order = 2)]
        public string ApplicationUserId { get; set; }


        public ICollection<Game> Games { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}