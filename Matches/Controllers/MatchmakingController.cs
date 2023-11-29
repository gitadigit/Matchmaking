using Matches.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Solid.Core.Services;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Matches.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchmakingController : ControllerBase
    {
        private readonly InterfaceMatchmakingServices _matchmakingServices;
        public MatchmakingController(InterfaceMatchmakingServices matchmakingServices)
        {
            _matchmakingServices = matchmakingServices;
        }

        // GET: api/<MatchmakingController>
        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_matchmakingServices.GetEMatchmakings());  
        }

        // GET api/<MatchmakingController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var match = _matchmakingServices.GetByIdMatchmakings(id);
            if (match is null)
                return NotFound();
            return Ok(match);
        }

        // POST api/<MatchmakingController>
        [HttpPost]
        public void Post([FromBody] Matchmaking value)
        {
            _matchmakingServices.AddMatchmaking(value);
        }

        // PUT api/<MatchmakingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Matchmaking value)
        {
            _matchmakingServices.UpdateMatchmaking(id,value);
            
        }

        // DELETE api/<MatchmakingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _matchmakingServices.DeleteMatchmaking(id);
            
        }
    }
}
