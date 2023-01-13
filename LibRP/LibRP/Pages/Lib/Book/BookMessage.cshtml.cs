using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibRP.Pages.Lib.Book
{
    public class BookMessageModel : PageModel
    {
        public string t { get; set; }
        public int i { get; set; }
        public void OnGet(string title, int id)
        {
            t= title;
            i= id;
        }
    }
}
