using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeBataillon.Database.Models
{
    public class Team
    {
        
        public Team()
        {


        }

        public Team(int Id, string TeamName, int? Captain)
        {
            this.Id = Id;
            this.TeamName = TeamName;
            this.CaptainId = Captain;
        } 
        public void EditFrom(Team t)
        {
            this.Id = t.Id;
            this.TeamName = t.TeamName;
            this.CaptainId = t.CaptainId;

        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<int> listJoueurId = new List<int>();
            foreach(Player listPlayer in Players){
                if(listJoueurId.Contains(listPlayer.Id))
                    yield return new ValidationResult("Ne peut pas avoir 2 joueurs identique dans la même équipe", new[] {nameof(this.Players)});
                listJoueurId.Add(listPlayer.Id);
            }
        }

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Le TeamName est requis")]
        public string TeamName { get; set; }
        public int? CaptainId { get; set; }

        [ForeignKey("CaptainId")]
        public Player Captain;

        [InverseProperty("Team")]
        public List<Player> Players;

    }
}