using System;
using System.ComponentModel.DataAnnotations;

namespace ComposedViewModels.ViewModels.Fields
{
    public class DateOfBirthInformation : IPageField
    {
        public bool AppliesToPage(PageName pageName)
        {
            return pageName == PageName.PersonalInformation && DateTime.Now.Minute%2 == 0;
        }

        public int FieldOrder
        {
            get {return 1; }
        }

        [Required(ErrorMessage="When were you born?")]
        public string DateOfBirth { get; set; }
    }
}