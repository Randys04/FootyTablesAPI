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