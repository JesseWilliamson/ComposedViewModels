using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace ComposedViewModels.ViewModels.Fields
{
    public interface IPageField
    {
        bool AppliesToPage(PageName pageName);
        int FieldOrder { get; }
    }
}
