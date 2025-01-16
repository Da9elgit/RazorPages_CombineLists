using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_CombineLists.Models;

namespace RazorPages_CombineLists.Pages.Cars
{
    public class IndexModel : PageModel
    {
        public IDatabase dbinjection;
        public IndexModel(IDatabase db)
        {
            dbinjection = db;
        }
        public void OnGet()
        {
        }
    }
}
