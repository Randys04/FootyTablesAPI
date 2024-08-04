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
            try
            {
                return Ok();
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
                return Ok();
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

        
    }
}