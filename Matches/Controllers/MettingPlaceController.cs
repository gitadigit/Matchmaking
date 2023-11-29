using Matches.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Matches.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MettingPlaceController : ControllerBase
    {
        private InterfaceMeetingPlaceServices _meetingPlaceServices;
        public MettingPlaceController(InterfaceMeetingPlaceServices meetingPlaceServices)
        {
            _meetingPlaceServices = meetingPlaceServices;
        }

        // GET: api/<MettingPlaceController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_meetingPlaceServices.GetMeetingPlaces());
        }

        // GET api/<MettingPlaceController>/5
        [HttpGet("{id}")]
        public ActionResult<MeetingPlace> Get(string namePlace)
        {
            var place = _meetingPlaceServices.GetMeetingPlaceById(namePlace);
            if (place is null)
                return NotFound();
            return Ok(place);   
        }

        // POST api/<MettingPlaceController>
        [HttpPost]
        public void Post([FromBody] MeetingPlace value)
        {
            _meetingPlaceServices.AddMeetingPlace(value);
        }

        // PUT api/<MettingPlaceController>/5
        [HttpPut("{id}")]
        public void Put(string namePlace, [FromBody] MeetingPlace value)
        {
            _meetingPlaceServices.UpdateMeetingPlace(namePlace, value);
        }

        // DELETE api/<MettingPlaceController>/5
        [HttpDelete("{id}")]
        public void Delete(string namePlace)
        {
             _meetingPlaceServices.DeleteMeetingPlace(namePlace);
            
        }
    }
}
