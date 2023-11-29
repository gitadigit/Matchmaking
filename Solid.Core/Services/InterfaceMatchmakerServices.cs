using Matches.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface InterfaceMatchmakerServices
    {
        List<Matchmaker> GetMatchmakers();

        Matchmaker GetByIdMatchmaker(int id);

        Matchmaker AddMatchmaker(Matchmaker matchmaker);

        Matchmaker UpdateMatchmaker(int id, Matchmaker matchmaker);

        void DeleteMatchmaker(int id);
    }
}
