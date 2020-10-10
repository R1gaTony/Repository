using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeBataillon.Database.Models
{
    public class Game : IValidatableObject
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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           
           if(DateTime.Now.AddDays(1) >= this.GameDateTime){

                    yield return new ValidationResult("Doit etre 24h dans le futur", new[] {nameof(this.GameDateTime)});

           }
        }

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        [Required]
        public DateTime GameDateTime { get; set; }
       
        public int? TeamDefendantId { get; set; }
        public virtual Team TeamDefendant {get; set;}

        public int? TeamAttackerId { get; set; }
        public virtual Team TeamAttacker {get;set;}
    }
}