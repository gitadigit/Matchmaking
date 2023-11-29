//using Matches.Entities;
using Matches.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using System.Net.Mail;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Matches.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchmakerController : ControllerBase
    {
        private readonly InterfaceMatchmakerServices _matchmakerServices;
        public MatchmakerController(InterfaceMatchmakerServices matchmakerServices)
        {
            _matchmakerServices = matchmakerServices;
        }

        // GET: api/<MatchController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_matchmakerServices.GetMatchmakers());
        }

        // GET api/<MatchController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
                var matcher = _matchmakerServices.GetByIdMatchmaker(id);
            if (matcher is null)
                return NotFound();
            return Ok(matcher);
        }

        // POST api/<MatchController>
        [HttpPost]
        public void Post([FromBody] Matchmaker value)
        {
            _matchmakerServices.AddMatchmaker(value);
        }

        // PUT api/<MatchController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Matchmaker value)
        {
            var matchmakerId = _matchmakerServices.UpdateMatchmaker(id, value);
        }

        // DELETE api/<MatchController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _matchmakerServices.DeleteMatchmaker(id);
        }
    }
}
