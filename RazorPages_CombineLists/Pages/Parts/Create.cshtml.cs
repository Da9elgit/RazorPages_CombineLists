using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_CombineLists.Models;

namespace RazorPages_CombineLists.Pages.Parts
{
    public class CreateModel : PageModel
    {
        public IDatabase dbinjection;

        [BindProperty]
        public Engine myEngine { get; set; }

        public CreateModel(IDatabase db)
        {
            dbinjection = db;
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                dbinjection.addEngine(myEngine);
                RedirectToPage("Index");

            }
        }
    }
}
