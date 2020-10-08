using System;
using System.Collections.Generic;
using System.Linq;
using LeBataillon.Database.Context;
using LeBataillon.Database.Models;

// namespace LeBataillon.Database.Repository
// {
//     public class GameRepository
//     {
//         private readonly LeBataillonDbContext _context;
//         public GameRepository(LeBataillonDbContext context)
//         {
//             _context = context;
//         }

//         public List<Game> GetAll()
//         {
//             return _context.Games.ToList();
//         }

//         public Game GetById(int id)
//         {
//             return _context.Games
               
//                 .FirstOrDefault(m => m.GameId == id);
//         }
//         public void Add(Game game)
//         {
//             _context.Add(game);
//             _context.SaveChanges();
//         }

//         public void Edit(Game game)
//         {
//             _context.Update(game);
//             _context.SaveChanges();
//         }
//         public void Delete(int id)
//         {
//             var game = _context.Games.Find(id);
//             _context.Games.Remove(game);
//             _context.SaveChanges();
//         }
//     }
// }
