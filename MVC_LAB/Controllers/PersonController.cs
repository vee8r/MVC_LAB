using Microsoft.AspNetCore.Mvc;
using MVC_LAB.Models.Person;

namespace MVC_LAB.Controllers
{
    public class PersonController : Controller
    {
        

        public IActionResult Index()
        {
            var model = new PersonViewModel()
            {
                Persons = new PersonModel().GetPersons()
            };
            return View(model);
        }
    }
}
