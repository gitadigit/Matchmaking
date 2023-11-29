using Matches.Entities;
using Matches;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solid.Data.Repositories
{
    public class MeetingPlaceRepository:InterfaceMeetingPlaceRepository
    {
        private readonly DataContext _context;

        public MeetingPlaceRepository(DataContext context)
        {
            _context = context;
        }

        List<MeetingPlace> InterfaceMeetingPlaceRepository.GetMeetingPlaces()
        {
            throw new NotImplementedException();
        }
        List<MeetingPlace> GetMeetingPlaces()
        {
           return _context.meetingPlace;
        }


  

        public MeetingPlace GetByIdMeetingPlace(string namePlace)
        {
            return _context.meetingPlace.Find(m => m.NamePlace == namePlace);
        }

        public MeetingPlace AddMeetingPlace(MeetingPlace meetingPlace)
        {
            _context.meetingPlace.Add(meetingPlace);
            return meetingPlace;
        }

        public MeetingPlace UpdateMeetingPlace(string namePlace, MeetingPlace meetingPlace)
        {
            var updateMeetingPlace = _context.meetingPlace.Find(m => m.NamePlace == namePlace);
            if (updateMeetingPlace != null)
            {
                updateMeetingPlace.NamePlace = meetingPlace.NamePlace;
                updateMeetingPlace.Descriptuon = meetingPlace.Descriptuon;
                updateMeetingPlace.IsActive = meetingPlace.IsActive;
                updateMeetingPlace.IsSatisfied = meetingPlace.IsSatisfied;  
            }
            return null;
        }

        public void DeleteMeetingPlace(string namePlace)
        {
            _context.meetingPlace.Remove(_context.meetingPlace.Find(m => m.NamePlace == namePlace));

        }

    }
}
