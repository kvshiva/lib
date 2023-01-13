using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibServices.Book;
using LibServices;

namespace LibRP.Pages.Lib.Book
{
    public class BookInsertModel : PageModel
    {
        private readonly BookServices _bookservice;
        [BindProperty]
        public BookInsertionDto Input { get; set; }
        public BookInsertModel()
        {
            _bookservice = new BookServices();
            Input = new BookInsertionDto();
        }
       
        
        
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string t;
                    int i = _bookservice.Insert(Input, out t);
                    return RedirectToPage("BookMessage", new {title=t, id=i});
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }

            }

            else
            {
                throw new Exception("Invalid data!");
            }
        }
    }
   
}
