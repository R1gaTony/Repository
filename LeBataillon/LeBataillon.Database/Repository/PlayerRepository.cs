using System;
using System.Collections.Generic;
using System.Linq;
using LeBataillon.Database.Context;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.Repository
{
    public class PlayerRepository
    {
        private readonly LeBataillonDbContext _context;
        public PlayerRepository(LeBataillonDbContext context)
        {
            _context = context;
        }

        public List<Player> GetAll()
        {
            return _context.Players.ToList();
        }

        public Player GetById(int id)
        {
            return _context.Players
               
                .FirstOrDefault(m => m.Id == id);
        }
        public void Add(Player Player)
        {
            _context.Add(Player);
            _context.SaveChanges();
        }        
        public void Edit(Player Player)
        {
            _context.Update(Player);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var Player = _context.Players.Find(id);
            _context.Players.Remove(Player);
            _context.SaveChanges();
        }
    }
}
