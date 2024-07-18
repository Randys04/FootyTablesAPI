using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FootyTablesAPI
{
    public class FootyTablesIdentityContext  : IdentityDbContext<IdentityUser>
    {
        public FootyTablesIdentityContext (DbContextOptions<FootyTablesIdentityContext > options)
        : base(options)
        {
        }
    }
}