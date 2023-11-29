using Matches.Entities;
using Matches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Repositories;

namespace Solid.Data.Repositories
{
    public class MatchmakingRepository : InterfaceMatchmakingRepository
    {
        private readonly DataContext _context;

        public MatchmakingRepository(DataContext context)
        {
            _context = context;
        }
        public List<Matchmaking> GetEMatchmakings()
        {
            return _context.matchmaking;
        }
        public Matchmaking GetByIdMatchmakings(int id)
        {
            return _context.matchmaking.Find(m => m.Id == id);
        }

        public Matchmaking AddMatchmaking(Matchmaking matchmaking)
        {
            _context.matchmaking.Add(matchmaking);
            return matchmaking;
        }
        public Matchmaking UpdateMatchmaking(int id, Matchmaking matchmaking)
        {
            var updateMatchmaking = _context.matchmaking.Find(m => m.Id == id);
            if (updateMatchmaking != null)
            {
                updateMatchmaking.Id = matchmaking.Id;
                updateMatchmaking.LastName = matchmaking.LastName;
                updateMatchmaking.FirstName=matchmaking.FirstName;  
                updateMatchmaking.Email=matchmaking.Email;
                updateMatchmaking.status=matchmaking.status;
                updateMatchmaking.Age=matchmaking.Age;
                updateMatchmaking.IsChoen = matchmaking.IsChoen;
                updateMatchmaking.Phone = matchmaking.Phone;
            }
            return null;
        }

        public void DeleteMatchmaking(int id)
        {
            _context.matchmaking.Remove(_context.matchmaking.Find(m => m.Id == id));
        }

    }
}
