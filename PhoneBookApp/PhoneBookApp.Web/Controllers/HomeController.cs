using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.Web.Data.Context;
using PhoneBookApp.Web.Data.Interfaces;
using PhoneBookApp.Web.Data.Repositories;
using PhoneBookApp.Web.Mappings;

namespace PhoneBookApp.Web.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IPersonRepository _personRepository;
        private readonly IPersonMapper _personMapper;
        public HomeController( IPersonRepository personRepository, IPersonMapper personMapper)
        {
            
            _personRepository = personRepository;
            _personMapper = personMapper;
        }

        public IActionResult Index()
        {
            return View(_personMapper.MapToListOfUserList(_personRepository.GetAll()));
        }
    }
}
