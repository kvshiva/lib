using System;
using System.Collections.Generic;

namespace LibData.Entities
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int? Year { get; set; }
        public int? PublisherId { get; set; }
        public int? Isbn { get; set; }
        public short? CategoryId { get; set; }
        public int? FirstAuthorId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Author? FirstAuthor { get; set; }
        public virtual Publisher? Publisher { get; set; }
    }
}
