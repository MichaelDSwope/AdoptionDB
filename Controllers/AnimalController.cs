using AdoptionDB.Models;
using AdoptionDB.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace AdoptionDB.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AppDbContext _appDbContext;

        //We are injecting the DbContext into this controller through the constructor
        public AnimalController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index(string? breed)
        {
            if (breed == null)
            {
                List<Animal> animals = _appDbContext.Animals.OrderBy(x => x.Name).ToList();
                return View(animals);  
            }
            List<Animal> animalsbreed = _appDbContext.Animals.Where(y => y.Breed == breed).ToList();
            return View(animalsbreed);
            

        }
       

    }
}
