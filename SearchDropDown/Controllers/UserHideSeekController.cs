using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SearchDropDown.Models;

namespace SearchDropDown.Controllers
{
    public class UserHideSeekController : Controller
    {
        DropDown1Entities db = new DropDown1Entities();
        // GET: UserHideSeek
        public ActionResult Index()
        {
            ViewBag.UserData = new SelectList(db.tblUsers, "userId", "UserName");
            return View();
        }
        public JsonResult getUserDetails(int id)
        {
            return Json(db.tblUsers.Find(id), JsonRequestBehavior.AllowGet);
        }
    }
}