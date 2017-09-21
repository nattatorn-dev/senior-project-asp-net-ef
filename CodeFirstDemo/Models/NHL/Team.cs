using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models.NHL
{
    public class Team
    {
        [Key]
        [MaxLength(30)]
        public string TeamName { get; set; } // Make it a primary key
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }

        // Team has a relationship with players - A team can have many players - one to many relationship
        public List<Player> Players { get; set; }
    }
}