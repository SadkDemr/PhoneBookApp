using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.Web.Data.Context;
using PhoneBookApp.Web.Data.Repositories;
using PhoneBookApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Web.Controllers
{
    public class InformationController : Controller
    {
        private readonly PhoneContext _context;
        private readonly PersonRepository personRepository; 
        public InformationController(PhoneContext context)
        {
            _context = context;
            personRepository = new PersonRepository(_context);
        }
        public IActionResult Create(int id)
        {
            var userInfo = personRepository.GetById(id);
            return View(userInfo);
        }
        [HttpPost]
        public IActionResult Create(InformationCreateModel model)
        {
            _context.Informations.Add(new Data.Entities.Information { 
            MobileNumber= model.MobileNumber,
            OfficePhone=model.OfficePhone,
            HomePhone=model.HomePhone,
            Mail=model.Mail,
            Adress=model.Adress,
            PersonsID=model.PersonsID

            });
            _context.SaveChanges();

            return RedirectToAction ("Index","Home");
        }
    }
}
