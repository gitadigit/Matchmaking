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
    public class MeetingPlaceService: InterfaceMeetingPlaceServices
    {
        private readonly InterfaceMeetingPlaceRepository _meetingPlaceRepository;
        public MeetingPlaceService(InterfaceMeetingPlaceRepository meetingPlaceRepository)
        {
            _meetingPlaceRepository = meetingPlaceRepository;
        }

        public MeetingPlace AddMeetingPlace(MeetingPlace meetingPlace)
        {
            return _meetingPlaceRepository.AddMeetingPlace(meetingPlace);
        }

        public void DeleteMeetingPlace(string namePlace)
        {
            _meetingPlaceRepository.DeleteMeetingPlace(namePlace);
        }

        public MeetingPlace GetMeetingPlaceById(string namePlace)
        {
            return _meetingPlaceRepository.GetByIdMeetingPlace(namePlace);  
        }

        public List<MeetingPlace> GetMeetingPlaces()
        {
            return _meetingPlaceRepository.GetMeetingPlaces();
        }

        public MeetingPlace UpdateMeetingPlace(string namePlace, MeetingPlace meetingPlace)
        {
          return _meetingPlaceRepository.UpdateMeetingPlace(namePlace, meetingPlace);   
        }
    }
}
