using PhoneBookApp.Web.Data.Context;
using PhoneBookApp.Web.Data.Entities;
using PhoneBookApp.Web.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Web.Data.Repositories
{
    public class InformationRepository : IInformationRepository
    {
        private readonly PhoneContext _context;

        public InformationRepository(PhoneContext context)
        {
            _context = context;
        }
        public void Create(Information information)
        {
            _context.Informations.Add(information);
            _context.SaveChanges();
        }
    }
}
