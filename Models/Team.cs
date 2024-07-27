using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootyTablesAPI.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? UserID { get; set; }

        public ICollection<RankingTableContent>? RankingTableContents { get; set; }
    }
}