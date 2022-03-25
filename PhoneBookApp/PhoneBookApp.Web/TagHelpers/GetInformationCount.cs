using Microsoft.AspNetCore.Razor.TagHelpers;
using PhoneBookApp.Web.Data.Context;
using System.Linq;

namespace PhoneBookApp.Web.TagHelpers
{
    [HtmlTargetElement("getInformationCount")]
    [HtmlTargetElement("getinformationMobilNumber")]
    public class GetInformationCount : TagHelper
    {
        public int PersonsID { get; set; }
        private readonly PhoneContext _context;
        public GetInformationCount(PhoneContext context)
        {
            _context= context;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var informationCount = _context.Informations.Count(x => x.PersonsID == PersonsID );
            
            var html = $"<spanclass='badge bg-danger'>{informationCount} </span>";
            
            output.Content.SetHtmlContent(html);
            
        }
    }
}
