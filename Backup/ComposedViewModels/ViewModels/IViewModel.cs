using System.Collections.Generic;
using ComposedViewModels.ViewModels.Fields;

namespace ComposedViewModels.ViewModels
{
    public interface IViewModel
    {
        string PageTitle{get;}
        IEnumerable<IPageField> Fields { get; set; }
    }
}