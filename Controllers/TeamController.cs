using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootyTablesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootyTablesAPI.Controllers
{
    
    [Route("FootyTables/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly FootyTablesContext _contextFootyTables;

        public TeamController(FootyTablesContext contextFootyTables)
        {
            _contextFootyTables = contextFootyTables;
        }

        [HttpGet("{teamId}")]
        public ActionResult<Team> Get(int teamId, string userId)
        {
            try
            {
                var team = _contextFootyTables.Team.FirstOrDefault(x => x.UserID == userId && x.TeamID == teamId);
                return Ok(team);
            }
            catch (System.Exception)
            {
                return BadRequest(new {
                    error = "Error getting",
                    message = "Error al intentar obtener el equipo"
                });
            }
        }

        [HttpGet]
        public ActionResult<List<Team>> GetAll(string userId)
        {
            try
            {
                var teamsList = _contextFootyTables.Team.ToList().Where(x => x.UserID == userId);
                return Ok(teamsList);
            }
            catch (System.Exception)
            {
                return BadRequest(new {
                    error = "Error getting",
                    message = "Error al intentar obtener el equipo"
                });
            }
        }    

        [HttpPost]
        public ActionResult<Team> Create(Team team)
        {
            try
            {
                _contextFootyTables.Add(team);
                _contextFootyTables.SaveChanges();
                return Ok(team);
            }
            catch (System.Exception)
            {
                return BadRequest(new {
                    error = "Error creating",
                    message = "Error al crear el equipo"
                });
            }
        }
        
    }
}