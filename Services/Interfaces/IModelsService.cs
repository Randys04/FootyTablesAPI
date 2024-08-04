using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootyTablesAPI.Models;

namespace FootyTablesAPI.Services.Interfaces
{
    public interface IModelsService
    {
        public Team Get(int teamId, string userId);
        public List<Team> GetAll(string userId);
        public bool Add(Team team);
        public bool Edit(Team team);
        public bool Delete(int teamId);
    }
}