using System;
using System.Collections.Generic;
using LeBataillon.Database.Initializer.DataFixtures;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.Context
{
    public class PlayerData
    {
        public PlayerData()
        {
            this.EnsureCreated();
        }
        public List<Team> Teams = new List<Team>();
        public  List<Player> Players = new List<Player>();

        public  List<Game> Games = new List<Game>();
        public void EnsureCreated()
        {
            for (int i = 1; i <= 10; i++) //10 équipes
            {
                      
                var teamName = "Équipe de " + SampleData.GenerateName(i);
                Teams.Add(new Team(i, teamName, null)); //équipe 1, capitaine > player 1, //équpe 2, capitaine > player 2
            }
            for (int i = 1; i < 100; i++)
            {
              var name = SampleData.GenerateName(10+i);//pour pas avoir le même nom
              var player = new Player(i,  $"{name}Alias", $"{name}@bataillonMail.com", SampleData.GeneratePhoneNumber(i),name, SampleData.GenerateLastName(i), SampleData.GenerateLevel());
              
              Players.Add(player);
            
            //avec les navigations qu'on vous demande, il devrait y avoir un teamid
              player.TeamId = (i <= 10) ? i : SampleData.GenerateInteger(i,1,10);
            
            } 
            //int Id, DateTime GameDateTime, int TeamDefendant, int TeamAttacker
            Games.Add(new Game(1, new DateTime(DateTime.Now.Year+1,10,24),1,3));
            Games.Add(new Game(2, new DateTime(DateTime.Now.Year+1,10,24),4,6));
            Games.Add(new Game(3, new DateTime(DateTime.Now.Year+1,10,24),7,2));           
        }
    }
}
