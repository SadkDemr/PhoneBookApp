using PhoneBookApp.Web.Data.Entities;
using PhoneBookApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Web.Mappings
{
    public class PersonMapper : IPersonMapper
    {
        public List<PersonListModel> MapToListOfUserList(List<Person> users)
        {
            return users.Select(x => new PersonListModel
            {
                Id = x.Id,
                PersonsFullName = x.PersonsFullName
            }).ToList();
        }

        public PersonListModel MapToUsersList(Person user)
        {
            return new PersonListModel
            {
                Id = user.Id,
                PersonsFullName = user.PersonsFullName
            };
        }
    }
}
