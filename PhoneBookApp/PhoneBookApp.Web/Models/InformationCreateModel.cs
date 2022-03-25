using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Web.Models
{
    public class InformationCreateModel
    {
        public string HomePhone { get; set; }
        public string MobileNumber { get; set; }
        public string OfficePhone { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public int PersonsID { get; set; }
    }
}
