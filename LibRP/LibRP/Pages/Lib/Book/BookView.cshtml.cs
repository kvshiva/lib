using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibServices.Book;

namespace LibRP.Pages.Lib.Book
{
    public class BookViewModel : PageModel
    {
        private readonly BookServices _bookServices;
        public List<BookDto> AllBooks { get; set; }
        public BookViewModel(/*BookServices bookServices*/)
        {
            _bookServices = new BookServices();
            AllBooks = new List<BookDto>();
        }
        

        public void OnGet()
        {
            AllBooks=_bookServices.Search(true, new());
        }
    }
}
