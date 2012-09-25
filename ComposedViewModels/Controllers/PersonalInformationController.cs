using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ComposedViewModels.Models;
using ComposedViewModels.ViewModels;
using ComposedViewModels.ViewModels.Fields;

namespace ComposedViewModels.Controllers
{
    public class PersonalInformationController : BaseController
    {
        //
        // GET: /PersonalInformation/

        private Person _person;

        public PersonalInformationController(IEnumerable<IPageField> fields, Person person) : base(fields)
        {
            _person = person;
        }

        public ActionResult Index()
        {
            var fields = Fields
                .Where(field => field.AppliesToPage(PageName.PersonalInformation))
                .OrderBy(field => field.FieldOrder);
            var model = new PersonalInformationViewModel {Fields = fields};
            return View(model);
        }

        public ActionResult Save(PersonalInformationViewModel model)
        {
            if (!ModelState.IsValid)
                return View("Index", model);
            Person person = Mapper.Map<PersonalInformationViewModel, Person>(model);
            return RedirectToAction("Index", "AddressInformation");
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
