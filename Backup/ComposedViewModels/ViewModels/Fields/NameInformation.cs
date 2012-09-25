using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComposedViewModels.ViewModels.Fields
{
    public class NameInformation : IPageField
    {
        public bool AppliesToPage(PageName pageName)
        {
            return pageName == PageName.PersonalInformation;
        }

        public int FieldOrder
        {
            get { return 0; }
        }

        [Required(ErrorMessage = "We need to know your first name")]
        [RegularExpression(@"[a-zA-Z][a-zA-Z\s'-]{1,25}$", ErrorMessage = "Only letters please")]
        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "We need to know your last name")]
        [RegularExpression(@"[a-zA-Z][a-zA-Z\s'-]{1,25}$", ErrorMessage = "Only letters please")]
        public string LastName { get; set; }
    }
}