using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootyTablesAPI.Models;
using FootyTablesAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FootyTablesAPI.Services.Implementations
{
    public class TeamService : ITeamService
    {
        private readonly FootyTablesContext _contextFootyTables;

        public TeamService(FootyTablesContext contextFootyTables)
        {
            _contextFootyTables = contextFootyTables;
        }

        public bool Add(Team team)
        {
            try
            {
                _contextFootyTables.Add(team);
                _contextFootyTables.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                
                return false;
            }
        }

        public bool Delete(int teamId)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Team team)
        {
            throw new NotImplementedException();
        }

        public Team Get(int teamId, string userId)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetAll(string userId)
        {
            throw new NotImplementedException();
        }
    }
}