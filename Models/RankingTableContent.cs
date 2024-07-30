using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootyTablesAPI.Models
{
    public class RankingTableContent
    {
        public int RankingTableContentId { get; set; }
        public int TeamID { get; set; }
        public int RankingTableID { get; set; }
        public int Points { get; set; }
        public int GoalDifference { get; set; }
        public int GoalsConceded { get; set; }
        public int GoalsScored { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int MatchesPlayed { get; set; }

        public Team? Team { get; set; }
        public RankingTable? RankingTable { get; set; }
    }
}