﻿using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.Web.Data.Context;
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
       
        private readonly IPersonRepository _personRepository;
        private readonly IInformationRepository _informationRepository;
        private readonly IPersonMapper _personMapper;
        private readonly IInformationMapper _informationMapper;
        public InformationController(IPersonMapper personMapper, IPersonRepository personRepository, IInformationRepository informationRepository, IInformationMapper informationMapper)
        {
           
            _personMapper = personMapper;
            _personRepository = personRepository;
            _informationRepository = informationRepository;
            _informationMapper = informationMapper;
        }
        public IActionResult Create(int id)
        {
            var userInfo =_personMapper.MapToUsersList(_personRepository.GetById(id));
            return View(userInfo);
        }
        [HttpPost]
        public IActionResult Create(InformationCreateModel model)
        {
            _informationRepository.Create(_informationMapper.Map(model));

            return RedirectToAction ("Index","Home");
        }
    }
}
