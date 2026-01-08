
using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCoreApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Book> BooksTable { get; set; }
        public DbSet<Language> languageTable { get; set; }

    }
}
