using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAPP.Models;

namespace MVCAPP.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            // Sample list of BGs
            var bloodGrps = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Selected = false, Text =  "O+ve", Value =  "O+ve"},
                    new SelectListItem { Selected = false, Text = "O-ve", Value = "O-ve"},
                    new SelectListItem { Selected = false, Text = "A+ve", Value = "A+ve"},
                     new SelectListItem { Selected = false, Text = "AB+ve", Value = "AB+ve"},
                      new SelectListItem { Selected = false, Text = "AB-ve", Value = "AB-ve"},
                       new SelectListItem { Selected = false, Text = "B+ve", Value = "B+ve"},
                       new SelectListItem { Selected = false, Text = "B-ve", Value = "B-ve"},
                }, "Value", "Text", 1);

            //ViewData will hold BGs for DroupDown
            ViewData["BloodGroups"] = bloodGrps;
            return View();
        }

        [HttpPost]
        public ActionResult SaveData(RegistrationModel model)
        {
            return Content("Thanks For Registering");
        }
    }
}