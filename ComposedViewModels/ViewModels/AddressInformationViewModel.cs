using System.Collections.Generic;
using ComposedViewModels.ViewModels.Fields;

namespace ComposedViewModels.ViewModels
{
    public class AddressInformationViewModel : IComposedModel
    {
        public string PageTitle { get { return "Address Information"; } }
        public IEnumerable<IPageField> Fields { get; set; } 
    }
}