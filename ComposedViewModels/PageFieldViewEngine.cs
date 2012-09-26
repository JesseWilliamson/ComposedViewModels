using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComposedViewModels
{
    public class PageFieldViewEngine : RazorViewEngine
    {
        public PageFieldViewEngine()
        {
            base.PartialViewLocationFormats = new string[]
                                                  {
                                                      "~/Views/{1}/{0}.cshtml",
                                                      "~/Views/Shared/{0}.cshtml",                                                      
                                                      "~/Views/{0}.cshtml"
                                                  };
        }
    }
}