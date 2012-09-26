using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComposedViewModels.Models;
using ComposedViewModels.ViewModels;
using ComposedViewModels.ViewModels.Fields;

namespace ComposedViewModels.Controllers
{
    public class AddressInformationController : BaseController
    {
        public AddressInformationController(IEnumerable<IPageField> fields) : base(fields)
        {
        }

        public ActionResult Index()
        {
            
            var fields = Fields
                            .Where(field => field.AppliesToPage(PageName.AddressInformation))
                            .OrderBy(field => field.FieldOrder());

            var model = new AddressInformationViewModel {Fields = fields};

            return View(model);
        }
    }
}