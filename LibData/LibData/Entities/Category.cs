using System;
using System.Collections.Generic;

namespace LibData.Entities
{
    public partial class Category
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }

        public short Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
