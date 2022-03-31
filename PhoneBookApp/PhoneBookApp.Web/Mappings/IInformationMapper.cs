using PhoneBookApp.Web.Data.Entities;
using PhoneBookApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Web.Mappings
{
    public interface IInformationMapper
    {
        public Information Map(InformationCreateModel model);
    }
}
