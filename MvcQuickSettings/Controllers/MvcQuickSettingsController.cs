using System.Web.Mvc;
using DotNetNuke.Web.Mvc.Framework.Controllers;

namespace Demo.MvcQuickSettings.Controllers
{
    public class MvcQuickSettingsController : DnnController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult View2()
        {
            return View();
        }
        
        // Until we get the bug fixed in DNN, this CANNOT be named QuickSettings as it will
        // cause a conflict with DNN's QuickSettings implementation, causing the module to not
        // be able to be deleted from a page.  For now, just remove the s from the file name.
        public ActionResult QuickSetting()
        {
            return View();
        }
    }
}