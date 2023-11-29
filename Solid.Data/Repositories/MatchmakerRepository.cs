using Matches;
using Matches.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class MatchmakerRepository : InterfaceMatchmakerRepository
    {
        private readonly DataContext _context;
        public MatchmakerRepository(DataContext context)
        {
            _context = context;
        }

        public List<Matchmaker> GetMatchmakers()
        {
            return _context.matchmakers;
        }

        public Matchmaker GetByIdMatchmaker(int id)
        {
            return _context.matchmakers.Find(m => m.Id == id);
        }

        public Matchmaker AddMatchmaker(Matchmaker matchmaker)
        {
            _context.matchmakers.Add(matchmaker);
            return matchmaker;
        }
        public Matchmaker UpdateMatchmaker(int id, Matchmaker matchmaker)
        {
            var updateMatchmaker = _context.matchmakers.Find(m => m.Id == id);  
            if(updateMatchmaker != null)
            {
                updateMatchmaker.Id = matchmaker.Id;
                updateMatchmaker.FirstName = matchmaker.FirstName;
                updateMatchmaker.LastName = matchmaker.LastName;
                updateMatchmaker.Email = matchmaker.Email;  
                updateMatchmaker.Phone = matchmaker.Phone;
            }
            return null;
        }

        public void DeleteMatchmaker(int id)
        {
            _context.matchmakers.Remove(_context.matchmakers.Find(m => m.Id ==id));
        }
    }
}
