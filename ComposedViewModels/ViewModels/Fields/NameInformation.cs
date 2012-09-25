using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ComposedViewModels.Models;

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
        

        [Required(ErrorMessage = "Look, Ma! Validation works!!!")]        
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
    }
}