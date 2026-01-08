
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace DbOperationWithEFCoreApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
