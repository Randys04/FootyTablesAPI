using FootyTablesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootyTablesAPI
{
    public class FootyTablesContext : DbContext
    {
        public FootyTablesContext(DbContextOptions<FootyTablesContext> options)
        : base(options)
        {
        }
        public DbSet<Team> Team { get; set; }
        public DbSet<RankingTableContent> RankingTablesContent { get; set; }
        public DbSet<RankingTable> RankingTable { get; set; }
    }
}