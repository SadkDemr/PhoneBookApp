using PhoneBookApp.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Web.Data.Interfaces
{
    public interface IPersonRepository
    {
        List<Person> GetAll();

        public Person GetById(int id);
    }
}
