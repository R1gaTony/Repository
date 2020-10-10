using System;
using System.Collections.Generic;
using System.Linq;
using LeBataillon.Database.Initializer.DataFixtures;
using LeBataillon.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LeBataillon.Database.Context
{
    public class LeBataillonDbContext : DbContext
    {       
        public DbSet<Game> Games {get;set;}
        public DbSet<Player> Players {get;set;}
        public DbSet<Team> Teams {get;set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
                optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //seed
            PlayerData List = new PlayerData();

            modelBuilder.Entity<Player>().HasData(List.Players);
            modelBuilder.Entity<Game>().HasData(List.Games);
            modelBuilder.Entity<Team>().HasData(List.Teams);

        }
        public LeBataillonDbContext(DbContextOptions<LeBataillonDbContext> options) : base(options)
        {
            
        }
    }
}