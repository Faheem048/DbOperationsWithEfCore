
using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCoreApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CurrencyTable(modelBuilder);
            LanguageTable(modelBuilder);
        }


        void CurrencyTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyType>().HasData(
            new CurrencyType() { Id = 1, Currency = "PKR", Description = "Pakistani Rupees" },
            new CurrencyType() { Id = 2, Currency = "INR", Description = "Indian Rupees" },
            new CurrencyType() { Id = 3, Currency = "Dollar", Description = "USA Dollar" },
            new CurrencyType() { Id = 4, Currency = "Euro", Description = "European Euro" }
             );

        }

        void LanguageTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
            new Language() { Id = 1, Title = "English", Description = "English Language" },
            new Language() { Id = 2, Title = "Hindi", Description = "Indian Language" },
            new Language() { Id = 3, Title = "Urdu", Description = "Pakistani Language" },
            new Language() { Id = 4, Title = "Spanish", Description = "European Language" }
             );

        }


        public DbSet<Book> BooksTable { get; set; }
        public DbSet<Language> languageTable { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<CurrencyType> CurrencyTypes { get; set; }

    }
}
