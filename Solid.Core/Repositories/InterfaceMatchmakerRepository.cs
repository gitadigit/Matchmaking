using Matches.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface InterfaceMatchmakerRepository
    {
        List<Matchmaker> GetMatchmakers();

        Matchmaker GetByIdMatchmaker(int id);

        Matchmaker AddMatchmaker(Matchmaker matchmaker);

        Matchmaker UpdateMatchmaker(int id, Matchmaker matchmaker); 

        void DeleteMatchmaker(int id);

    }
}
