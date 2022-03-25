namespace PhoneBookApp.Web.Data.Entities
{
    public class Information
    {
        public int Id { get; set; }
        public string HomePhone { get; set; }
        public string MobileNumber { get; set; }
        public string OfficePhone { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public int PersonsID { get; set; }
        public Person Person { get; set; }
    }
}
