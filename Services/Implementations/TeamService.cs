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

        public bool Delete(int teamId, string userId)
        {
            try
            {
                var teamDelete = Get(teamId, userId);
                _contextFootyTables.Remove(teamDelete);
                _contextFootyTables.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool Edit(Team team)
        {
            try
            {
                var teamEdit = Get(team.TeamID, team.UserID!);
                teamEdit.Name = team.Name;
                teamEdit.City = team.City;

                _contextFootyTables.Update(teamEdit);
                _contextFootyTables.SaveChanges();
                
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public Team Get(int teamId, string userId)
        {
            try
            {
                return _contextFootyTables.Team.FirstOrDefault(x => x.TeamID == teamId && x.UserID == userId)!;
            }
            catch (System.Exception)
            {
                return null!;
            }
        }

        public List<Team> GetAll(string userId)
        {
            try
            {
                return _contextFootyTables.Team.Where(x => x.UserID == userId).ToList();
            }
            catch (System.Exception)
            {
                return null!;
            }
        }
    }
}