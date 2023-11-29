using Matches.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface InterfaceMeetingPlaceRepository
    {
        List<MeetingPlace> GetMeetingPlaces();

        MeetingPlace GetByIdMeetingPlace(string namePlace);   

        MeetingPlace AddMeetingPlace(MeetingPlace meetingPlace);
            
        MeetingPlace UpdateMeetingPlace(string namePlace, MeetingPlace meetingPlace);

        void DeleteMeetingPlace(string namePlace);
    }
}
