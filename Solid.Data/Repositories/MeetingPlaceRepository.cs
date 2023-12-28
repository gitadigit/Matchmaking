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

        public List<MeetingPlace> GetMeetingPlaces()
        {
           return _context.meetingPlace.ToList();
        }


        public MeetingPlace GetByIdMeetingPlace(int id)
        {
            return _context.meetingPlace.ToList().Find(k => k.Id == id);
        }

        public MeetingPlace AddMeetingPlace(MeetingPlace meetingPlace)
        {
            _context.meetingPlace.Add(meetingPlace);
            return meetingPlace;
        }

        public MeetingPlace UpdateMeetingPlace(int id, MeetingPlace meetingPlace)
        {
            var updateMeetingPlace = _context.meetingPlace.ToList().Find(k => k.Id == id);
            if (updateMeetingPlace != null)
            {
                //updateMeetingPlace.KodePlace = kode;
                updateMeetingPlace.NamePlace = meetingPlace.NamePlace;
                updateMeetingPlace.Descriptuon = meetingPlace.Descriptuon;
                updateMeetingPlace.IsActive = meetingPlace.IsActive;
                updateMeetingPlace.IsSatisfied = meetingPlace.IsSatisfied;  
            }
            return null;
        }

        public void DeleteMeetingPlace(int id)
        {
            _context.meetingPlace.Remove(_context.meetingPlace.ToList().Find(k => k.Id == id));

        }

    }
}
