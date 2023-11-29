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
    public class MatchmakingService: InterfaceMatchmakingServices
    {
        private readonly InterfaceMatchmakingRepository _matchmakingRepository;
        public MatchmakingService(InterfaceMatchmakingRepository matchmakingRepository)
        {
            _matchmakingRepository = matchmakingRepository;
        }

        public void DeleteMatchmaking(int id)
        {
            _matchmakingRepository.DeleteMatchmaking(id);
        }

        public Matchmaking GetByIdMatchmakings(int id)
        {
           return _matchmakingRepository.GetByIdMatchmakings(id);
        }

        public List<Matchmaking> GetEMatchmakings()
        {
           return _matchmakingRepository.GetEMatchmakings();
        }

        public Matchmaking UpdateMatchmaking(int id, Matchmaking matchmaking)
        {
            return _matchmakingRepository.UpdateMatchmaking(id, matchmaking);
        }

        public Matchmaking AddMatchmaking(Matchmaking matchmaking)
        {
            return _matchmakingRepository.AddMatchmaking(matchmaking);
        }
    }
}
