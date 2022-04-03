using PhoneBookApp.Web.Data.Context;
using PhoneBookApp.Web.Data.Entities;
using PhoneBookApp.Web.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Web.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private PhoneContext _context;

        public PersonRepository(PhoneContext context)
        {
            _context = context;
           
        }

        public Person GetById(int id)
        {
            return _context.Persons.SingleOrDefault(x => x.Id == id);
        }

        public void Create(Person user)
        {
            _context.Set<Person>().Add(user);
            _context.SaveChanges();
        }
        public void Remove(Person user)
        {
            _context.Set<Person>().Remove(user);
            _context.SaveChanges();
        }

        public List<Person> GetAll()
        {
            return _context.Set<Person>().ToList();
        }
    }
}

