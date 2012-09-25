using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComposedViewModels.Models;
using ComposedViewModels.ViewModels.Fields;

namespace ComposedViewModels.ViewModels
{
    public class PersonalInformationViewModel : IComposedModel
    {
        public string PageTitle
        {
            get { return "Personal Information"; }
        }

        public IEnumerable<IPageField> Fields { get; set; }
    }
}