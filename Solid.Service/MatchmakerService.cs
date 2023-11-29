using Matches.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{

    public class MatchmakerService : InterfaceMatchmakerServices
    {
        private readonly InterfaceMatchmakerRepository _matchmakerRepository;

        public MatchmakerService(InterfaceMatchmakerRepository matchmakerRepository)
        {
            _matchmakerRepository = matchmakerRepository;
        }

        public Matchmaker AddMatchmaker(Matchmaker matchmaker)
        {
           return _matchmakerRepository.AddMatchmaker(matchmaker);
        }

        public void DeleteMatchmaker(int id)
        {
             _matchmakerRepository.DeleteMatchmaker(id);
        }

        public Matchmaker GetByIdMatchmaker(int id)
        {
            return _matchmakerRepository.GetByIdMatchmaker(id);
        }

        public List<Matchmaker> GetMatchmakers()
        {
            return _matchmakerRepository.GetMatchmakers();
        }

        public Matchmaker UpdateMatchmaker(int id, Matchmaker matchmaker)
        {
            return _matchmakerRepository.UpdateMatchmaker(id, matchmaker);  
        }
    }
}
