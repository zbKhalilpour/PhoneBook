using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace AppL.Controllers
{
    public class SimpleController : Controller
    {  
        public ActionResult Index()
        {
            var bz = new BL.PhoneBook();
            ViewBag.List = bz.GetInfo(); 
            return View();
        }

        public ActionResult Create(Models.PhoneBook m_PhoneBook)
        {
            var bz = new BL.PhoneBook();
            bz.Insert(m_PhoneBook);
            return Json( new { }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update(Models.PhoneBook m_PhoneBook)
        {
            var bz = new BL.PhoneBook();
            bz.UpdatePerson(m_PhoneBook);
            return Json(new {Message="succses" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(Models.PhoneBook m_PhoneBook)
        {
            var bz = new BL.PhoneBook();
            bz.DeletePerson(m_PhoneBook);
            return Json(new { Message = "succses" }, JsonRequestBehavior.AllowGet);
        }


    }
}