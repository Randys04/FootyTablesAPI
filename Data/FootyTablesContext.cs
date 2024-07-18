using Microsoft.EntityFrameworkCore;

namespace FootyTablesAPI
{
    public class FootyTablesContext : DbContext
    {
        public FootyTablesContext(DbContextOptions<FootyTablesContext> options)
        : base(options)
        {
        }
    }
}