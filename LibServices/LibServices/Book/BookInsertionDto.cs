using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibServices.Book
{
    public class BookInsertionDto
    {
        public string Title { get; set; } = null!;
        public int? Year { get; set; }
        public int? PublisherId { get; set; }
        public int? Isbn { get; set; }
        public short? CategoryId { get; set; }
        public int? FirstAuthorId { get; set; }
    }
}
