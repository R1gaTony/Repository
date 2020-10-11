using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public class TeamMockData
    {
        public static List<Team> GetTeamsTest()
        {
            var _Teams = new List<Team>();
            {
                new Team()
                {
                    Id = 1,
                    TeamName = "Équipe de Adrian"
                };
                new Team()
                {
                    Id = 2,
                    TeamName = "Équipe de Krissy"
                };
                new Team()
                {
                    Id = 3,
                    TeamName = "Équipe de Pat"
                };
                new Team()
                {
                    Id = 4,
                    TeamName = "Équipe de Palmira"
                };
                new Team()
                {
                    Id = 5,
                    TeamName = "Équipe de Ralph"
                };
            }
            return _Teams;
        }
    }
}