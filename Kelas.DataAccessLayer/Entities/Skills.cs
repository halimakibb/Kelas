using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kelas.DataAccessLayer.Entities
{
    public class Skills
    {
        public int SkillID { get; set; }
        public string SkillName { get; set; }
        public int ? SkillParentID { get; set; }
  
    }
}