using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.Web.Data.Context;
using PhoneBookApp.Web.Data.Entities;
using PhoneBookApp.Web.Data.Interfaces;
using PhoneBookApp.Web.Data.Repositories;
using PhoneBookApp.Web.Mappings;
using PhoneBookApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Web.Controllers
{
    public class InformationController : Controller
    {

        //private readonly IPersonRepository _personRepository;
        //private readonly IInformationRepository _informationRepository;
        //private readonly IPersonMapper _personMapper;
        //private readonly IInformationMapper _informationMapper;
        //public InformationController(IPersonMapper personMapper, IPersonRepository personRepository, IInformationRepository informationRepository, IInformationMapper informationMapper)
        //{

        //    _personMapper = personMapper;
        //    _personRepository = personRepository;
        //    _informationRepository = informationRepository;
        //    _informationMapper = informationMapper;
        //}

        private readonly IGenericRepository<Information> _informationRepository;
        private readonly IGenericRepository<Person> _personRepository;

        public InformationController(IGenericRepository<Information> informationRepository, IGenericRepository<Person> personRepository)
        {
            _informationRepository = informationRepository;
            _personRepository = personRepository;
        }

        public IActionResult Create(int id)
        {
            var userInfo = _personRepository.GetById(id);
            return View(new PersonListModel
            {
                PersonsFullName = userInfo.PersonsFullName

            });
        }
        [HttpPost]
        public IActionResult Create(InformationCreateModel model)
        {
            _informationRepository.Create(new Information
            {
                HomePhone = model.HomePhone,
                MobileNumber = model.MobileNumber,
                OfficePhone = model.OfficePhone,
                Mail = model.Mail,
                Adress = model.Adress,
                PersonsID = model.PersonsID

            });

            return RedirectToAction("Index", "Home");
        }
    }
}
