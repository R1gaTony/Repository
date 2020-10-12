using System;
using System.Collections.Generic;
using System.Linq;
using LeBataillon.Database.Context;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.Repository
{
    public interface ITeamRepository
    {
        void Add(Team Team);
        void Delete(int id);
        void Edit(Team Team);
        List<Team> GetAll();
        Team GetById(int id);
        object Index();
    }

    public class TeamRepository : ITeamRepository
    {
        private readonly LeBataillonDbContext _context;

        public TeamRepository(LeBataillonDbContext context)
        {
            _context = context;
        }

        public List<Team> GetAll()
        {
            return _context.Teams.ToList();
        }

        public object Index()
        {
            throw new NotImplementedException();
        }

        public Team GetById(int id)
        {
            return _context.Teams

                .FirstOrDefault(m => m.Id == id);
        }
        public void Add(Team Team)
        {
            _context.Add(Team);
            _context.SaveChanges();
        }
        public void Edit(Team Team)
        {
            _context.Update(Team);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var Team = _context.Teams.Find(id);
            _context.Teams.Remove(Team);
            _context.SaveChanges();
        }
    }
}
