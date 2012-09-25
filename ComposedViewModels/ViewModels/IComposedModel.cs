using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComposedViewModels.ViewModels.Fields;

namespace ComposedViewModels.ViewModels
{
    public interface IComposedModel
    {
        IEnumerable<IPageField> Fields { get; set; }
    }
}
