using CodeFirstDemo.Models.NHL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Data
{
    public class DummyData
    {
        // Seed data 
        public static System.Collections.Generic.List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team()
                {
                    TeamName = "Canucks",
                    City = "Vancouver",
                    Province = "BC",
                    Country = "Canada",
                },

                new Team()
                {
                    TeamName = "Oilers",
                    City = "Edmonton",
                    Province = "Alberta",
                    Country = "Canada",
                },

                new Team()
                {
                    TeamName = "Flames",
                    City = "Calgary",
                    Province = "Alberta",
                    Country = "Canada",
                },

                new Team()
                {
                    TeamName = "Sharks",
                    City = "San Jose",
                    Province = "California",
                    Country = "USA",
                }
            };

            return teams;
        }

        public static List<Player> GetPlayers(NHLContext context)
        {
            List<Player> players = new List<Player>()
             {
                 new Player()
                 {
                     FirstName = "SVEN",
                     LastName = "BAERTSCHI",
                     TeamName = context.Teams.Find("Canucks").TeamName,
                     Position = "Forward",
                 },

                 new Player()
                 {
                     FirstName = "Henrik",
                     LastName = "Sedin",
                     TeamName = context.Teams.Find("Canucks").TeamName,
                     Position = "Left Wing",
                 },

                 new Player()
                 {
                     FirstName = "John",
                     LastName = "Rooster",
                     TeamName = context.Teams.Find("Flames").TeamName,
                     Position = "Right Wing",
                 },

                 new Player()
                 {
                     FirstName = "Bob",
                     LastName = "Plumber",
                     TeamName = context.Teams.Find("Oilers").TeamName,
                     Position = "Defense"
                 },
             };
            return players;
        }
       
    }
}