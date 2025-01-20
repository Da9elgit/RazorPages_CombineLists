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
        public Car createdCar { get; set; } = new Car();

        public CreateModel(IDatabase db)
        {
            dbinjection = db;
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            dbinjection.createCar(createdCar, createdCar.Engine.Id);
            RedirectToPage("Index");
        }
    }
}
