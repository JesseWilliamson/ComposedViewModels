using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComposedViewModels.ViewModels;
using ComposedViewModels.ViewModels.Fields;

namespace ComposedViewModels.Controllers
{
    public class PersonalInformationController : BaseController
    {
        //
        // GET: /PersonalInformation/

        public PersonalInformationController(IEnumerable<IPageField> fields) : base(fields)
        {
        }

        public ActionResult Index()
        {
            var fields = Fields.Where(field => field.AppliesToPage(PageName.PersonalInformation));
            var model = new PersonalInformationViewModel {Fields = fields};
            return View();
        }

    }

    public abstract class BaseController : Controller
    {
        protected IEnumerable<IPageField> Fields;

        protected BaseController(IEnumerable<IPageField> fields)
        {
            Fields = fields;
        }        
    }
}
