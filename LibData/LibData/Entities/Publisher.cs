using System;
using System.Collections.Generic;

namespace LibData.Entities
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public string PublisherName { get; set; } = null!;
        public int PublisherCode { get; set; }
        public string? PublisherCity { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
