using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComposedViewModels.ViewModels.Fields
{
    public class AddressInformation : IPageField
    {
        public bool AppliesToPage(PageName pageName)
        {
            return pageName == PageName.AddressInformation;
        }

        public int FieldOrder
        {
            get { return 0; }
        }

        [Required(ErrorMessage = "This field is required.")]
        public string AddressLine1 { get; set; }
        
        public string AddressLine2 { get; set; }
        
        [Required(ErrorMessage = "What city do you live in?")]
        public string City { get; set; }

        [Required(ErrorMessage = "What state do you live in?")]
        public string State { get; set; }        
    }
}