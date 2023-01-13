using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibServices.Book
{
    public class BookSearchDto:BookDto
    {
        public int? year_from { get; set; }
        public int? year_to { get; set; }
    }
}
