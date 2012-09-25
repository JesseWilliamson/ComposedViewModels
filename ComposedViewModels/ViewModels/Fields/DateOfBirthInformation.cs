using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ComposedViewModels.Models;

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

        [DisplayName("Birthday")]
        public string DateOfBirth { get; set; }
    }
}