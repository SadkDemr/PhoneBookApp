

using PhoneBookApp.Web.Data.Entities;
using PhoneBookApp.Web.Models;

namespace PhoneBookApp.Web.Mappings
{
    public class InformationMapper : IInformationMapper
    {
        public Information Map(InformationCreateModel model)
        {
            return new Information
            {
                HomePhone = model.HomePhone,
                MobileNumber = model.MobileNumber,
                OfficePhone = model.OfficePhone,
                Mail = model.Mail,
                Adress = model.Adress,
                PersonsID = model.PersonsID
            };

        }
    }
}
