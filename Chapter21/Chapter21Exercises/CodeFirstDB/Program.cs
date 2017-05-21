using static System.Console;
using System.Linq;
using CodeFirstDB.Persistence;
using CodeFirstDB.Domain;

namespace CodeFirstDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookContext())
            {
                Book book1 = new Book { Title = "Beginning Visual C# 2015", Author = "Perkins"};
                Book book2 = new Book { Title = "T-SQL Pro", Author = "Coles" };

                db.Books.Add(book1);
                db.Books.Add(book2);

                db.SaveChanges();

                var query = from b in db.Books
                            orderby b.Title
                            select b;

                WriteLine("All books in the database");
                foreach(var book in query)
                {
                    WriteLine((book as Book).ToString());
                }
                WriteLine("Press any key to exit...");
                ReadKey();
            }
        }
    }
}
