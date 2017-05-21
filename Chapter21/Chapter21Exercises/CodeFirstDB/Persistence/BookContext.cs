using CodeFirstDB.Domain;
using System.Data.Entity;

namespace CodeFirstDB.Persistence
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
