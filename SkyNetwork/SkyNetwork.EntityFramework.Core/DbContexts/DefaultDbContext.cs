using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace SkyNetwork.EntityFramework.Core
{
    [AppDbContext("SkyNetwork", DbProvider.Sqlite)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}