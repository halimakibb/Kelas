﻿using System;
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
        SkillsBL skillsBL = new SkillsBL();
        public ActionResult Index()
        {
            return View();
        }

        private IList<Skills> SkillList(bool isParent, int skillId = 0)
        {
           
            List<Skills> skills = new List<Skills>();
            Skills defaultSkill = new Skills();
            defaultSkill.SkillID = -1;
            defaultSkill.SkillName = "Select Category";
            
            skills = skillsBL.getSkills(isParent);
            skills.Insert(0, defaultSkill);
            
            return skills;
        }


        [HttpGet]
        public ActionResult OrderPrivate()
        {
            
            ViewBag.SkillList = new SelectList(SkillList(true), "SkillID", "SkillName", -1);
            return View();
        }
        [HttpPost]
        public ActionResult GetSkill(int skillId)
        {
            List<Skills> skillsChild = new List<Skills>();
            skillsChild = skillsBL.getSkills(false, skillId);
            SelectList objSkillsChild = new SelectList(skillsChild, "SkillId", "SkillName");
            return Json(objSkillsChild);
        }


    }
}