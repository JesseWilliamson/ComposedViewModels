using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ComposedViewModels.Models;

namespace ComposedViewModels.ViewModels.Fields
{
    public class AddressInformation : IPageField
    {
        public bool AppliesToPage(PageName pageName)
        {
            return pageName == PageName.AddressInformation;
        }

        public int FieldOrder()
        {
            return 0;
        }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Address")]
        public string AddressLine1 { get; set; }
        
        [DisplayName("Schmadress")]
        public string AddressLine2 { get; set; }
                
        public string City { get; set; }
        
        public string State { get; set; }        
    }
}