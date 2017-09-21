using CodeFirstDemo.Models.NHL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Data
{
    public class NHLContext : DbContext
    {
        // We've this context class that is using connection stream which in web.config file
        public NHLContext(): base("Server=tcp:databasetest.database.windows.net,1433;Initial Catalog=MyServer;Persist Security Info=False;User ID=adminsql;Password=Deepikajose1,;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {

        }

        // Define the entities you want entity framework to create for you as database
        // Create a table for teams
        public DbSet<Team> Teams { get; set; }
        // Create a table for players
        public DbSet<Player> Players { get; set; }
    }
}