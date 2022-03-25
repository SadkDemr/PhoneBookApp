using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.Web.Data.Context;
using PhoneBookApp.Web.Data.Repositories;
using PhoneBookApp.Web.Models;
using System.Linq;

namespace PhoneBookApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly PhoneContext _context;
        private readonly PersonRepository personRepository;

        public HomeController(PhoneContext context)
        {
            _context = context;
            personRepository = new PersonRepository(_context);
        }
       
        public IActionResult Index()
        {
            return View(personRepository.GetAll());
        }
    }
}
