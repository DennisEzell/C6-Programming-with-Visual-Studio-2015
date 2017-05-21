using System.ComponentModel.DataAnnotations;

namespace CodeFirstDB.Domain
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        [Key]public int Code { get; set; }

        public override string ToString() => $"{Title} by {Author}, code={Code}";
    }
}
