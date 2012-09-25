using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ComposedViewModels.Models;

namespace ComposedViewModels.ViewModels.Fields
{
    public class PhoneNumberInformation : IPageField
    {
        public bool AppliesToPage(PageName pageName)
        {
            return pageName == PageName.PersonalInformation;
        }

        public int FieldOrder
        {
            get { return 2; }
        }

        [DisplayName("Home Phone")]
        public string HomePhoneNumber { get; set; }
        
        [DisplayName("Mobile Phone")]
        public string CellPhoneNumber { get; set; }

        [DisplayName("Work Phone")]
        public string WorkPhoneNumber { get; set; }
    }
}