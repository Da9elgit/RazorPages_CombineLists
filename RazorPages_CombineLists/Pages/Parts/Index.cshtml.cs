using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_CombineLists.Models;

namespace RazorPages_CombineLists.Pages.Parts
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