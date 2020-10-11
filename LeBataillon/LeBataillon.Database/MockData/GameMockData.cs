using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public class GameMockData
    {
        public static List<Game> GetGamesTest()
        {
            var _Games = new List<Game>();
            {
                new Game()
                {
                    Id = 1,
                    GameDateTime = new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    TeamAttackerId = 3,
                    TeamDefendantId = 1
                };
                new Game()
                {
                    Id = 2,
                    GameDateTime = new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    TeamAttackerId = 6,
                    TeamDefendantId = 4
                };
                new Game()
                {
                    Id = 3,
                    GameDateTime = new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    TeamAttackerId = 2,
                    TeamDefendantId = 7
                };
            }
            return _Games;
        }
    }
}