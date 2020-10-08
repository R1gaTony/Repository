using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeBataillon.Database.Models
{
    public class Game
    {
        public Game()
        {


        }

        public Game(int Id, DateTime GameDateTime, int TeamDefendant, int TeamAttacker)
        {
            this.Id = Id;
            this.GameDateTime = GameDateTime;
            this.TeamDefendantId = TeamDefendant;
            this.TeamAttackerId = TeamAttacker;

        } 

        public void EditFrom(Game g)
        {
            this.Id = g.Id;
            this.GameDateTime = g.GameDateTime;
            this.TeamDefendantId = g.TeamDefendantId;
            this.TeamAttackerId = g.TeamAttackerId;

        } 
        public int Id { get; set; }
        public DateTime GameDateTime { get; set; }
       
        public int TeamDefendantId { get; set; }
        public Team TeamDefendant {get; set;}

        public int TeamAttackerId { get; set; }
        public Team TeamAttacker {get;set;}
    }
}