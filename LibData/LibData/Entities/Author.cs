using System;
using System.Collections.Generic;

namespace LibData.Entities
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public int NationalCode { get; set; }
        public string Name { get; set; } = null!;
        public int? BirthYear { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
