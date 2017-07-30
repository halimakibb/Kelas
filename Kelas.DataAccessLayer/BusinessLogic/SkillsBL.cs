using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kelas.DataAccessLayer.Helper;
using Kelas.DataAccessLayer.Entities;
using System.Data.SqlClient;

namespace Kelas.DataAccessLayer.BusinessLogic
{
    public class SkillsBL
    {
      
        public List<Skills> getSkills()
        {
            List<Skills> skills = new List<Skills>();

            skills = DbTransaction.DbToList<Skills>("stp_GetSkills", true);
            return skills;
        }
    }
}