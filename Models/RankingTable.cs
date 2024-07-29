using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootyTablesAPI.Models
{
    public class RankingTable
    {
        public int RankingTableID { get; set; }
        public string? TournamentName { get; set; }
        public bool? TwoLegged { get; set; }
        public int? CurrentMatchday { get; set; }
        public string? UserID { get; set; }

        public ICollection<RankingTableContent>? RankingTableContents { get; set; }
    }
}