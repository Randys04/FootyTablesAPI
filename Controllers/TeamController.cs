using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootyTablesAPI.Models;
using FootyTablesAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FootyTablesAPI.Controllers
{
    
    [Route("FootyTables/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService _teamService)
        {
            teamService = _teamService;
        }

        [HttpGet("{teamId}/{userId}")]
        public ActionResult<Team> Get(int teamId, string userId)
        {
            var team = teamService.Get(teamId, userId);
            if(team is not null)
            {
                return Ok(team);
            }
            return BadRequest(new {
                error = "Error getting",
                message = "Error al intentar obtener el equipo"
            });
        }

        [HttpGet]
        public ActionResult<List<Team>> GetAll(string userId)
        {
            var teamsList = teamService.GetAll(userId);
            if(teamsList is not null)
            {
                return Ok(teamsList);
            }
            return BadRequest(new {
                error = "Error getting",
                message = "Error al intentar obtener los equipos"
            }); 
        }    

        [HttpPost]
        public ActionResult<Team> Add(Team team)
        {
            if (teamService.Add(team))
            {
                return Ok(team);
            }
            return BadRequest(new {
                error = "Error creating",
                message = "Error al crear el equipo"
            });
        }

        [HttpPut]
        public ActionResult<Team> Edit(Team team)
        {
            if (teamService.Edit(team))
            {
                return Ok(team);
            }
            return BadRequest(new {
                error = "Error editing",
                message = "Error al editar el equipo"
            });
        }

        [HttpDelete("{teamId}/{userId}")]
        public ActionResult<bool> Delete(int teamId, string userId)
        {
            if (teamService.Delete(teamId, userId))
            {
                return Ok(true);
            }
            return BadRequest(new {
                error = "Error deleting",
                message = "Error al eliminar el equipo"
            });
        }

        
    }
}