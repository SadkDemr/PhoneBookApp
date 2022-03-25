using System.Collections.Generic;

namespace PhoneBookApp.Web.Data.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string PersonsFullName { get; set; }

        public List<Information> Informations { get; set; }
    }
}
