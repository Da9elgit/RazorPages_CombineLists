using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_CombineLists.Models;

namespace RazorPages_CombineLists.Pages.Cars
{
    public class CreateModel : PageModel
    {
        public IDatabase dbinjection;
        public string[] carBrands = { "TOYOTA", "Ford", "Volkswagen", "AG", "BMW", "Honda", "Nissan", "Tesla", "Mercedes Benz", "General Motors", "Hyundai", "Porsche", "Chevrolet", "Ferrari", "Mazda", "BYD", "Lexus", "Audi", "SAIC Motor", "Stellantis", "Subaru", "Aston Martin", "Bentley", "Bugatti", "Kia" };


        [BindProperty]
        public Car createdCar { get; set; }

        [BindProperty]
        public bool TurboUpgrade { get; set; }
   

        public CreateModel(IDatabase db)
        {
            dbinjection = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (TurboUpgrade)
                {
                    Engine newEngine = new Engine
                    {
                        Id = createdCar.Engine.Count + 1,
                        DistanceKørtKm = 0,
                        Turbo = true
                    };
                    createdCar.Engine.Add(newEngine);
                }
                dbinjection.createCar(createdCar);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
