using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "We need to know your home phone number, please.")]
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
    }
}