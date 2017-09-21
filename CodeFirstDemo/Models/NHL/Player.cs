using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models.NHL
{
    public class Player
    {
        public int PlayerID { get; set; } // An identity - autoincremented primary key - starting with class name and adding ID
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public string TeamName { get; set; } // Foreign Key
        public Team Team { get; set; }  // Specify the object - Assemblance of foreign key
    }
}