using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kelas.DataAccessLayer.Entities;
using Kelas.DataAccessLayer.BusinessLogic;

namespace Kelas.Controllers
{
    public class OrderController : Controller
    {
        // GET: Skill
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrderTeacher()
        {
            ViewBag.Menu = MenuList();
            return View();
        }
        private IList<Skills> MenuList()
        {
            SkillsBL skillsBL = new SkillsBL();
            var list = skillsBL.getSkills();
            return list;
        }

        public ActionResult OrderPrivate()
        {
            
            return View();
        }

    }
}