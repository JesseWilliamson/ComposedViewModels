using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComposedViewModels
{
    public class PageFieldModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var typeValue = bindingContext.ValueProvider.GetValue(bindingContext.ModelName + ".ModelType");
            var type = Type.GetType(
                (string)typeValue.ConvertTo(typeof(String)),
                true
                );
            var model = Activator.CreateInstance(type);
            bindingContext.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(() => model, type);

            return base.BindModel(controllerContext, bindingContext);
        }
    }
}