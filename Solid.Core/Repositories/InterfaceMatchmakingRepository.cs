using Matches.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface InterfaceMatchmakingRepository
    {
        List<Matchmaking> GetEMatchmakings();

        Matchmaking GetByIdMatchmakings(int id);

        Matchmaking AddMatchmaking  (Matchmaking matchmaking);

        Matchmaking UpdateMatchmaking(int id, Matchmaking matchmaking);

        void DeleteMatchmaking(int id); 
    }
}
