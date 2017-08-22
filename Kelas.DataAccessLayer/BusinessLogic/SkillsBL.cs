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
      
        public List<Skills> getSkills(bool isParent, int skillParentID = 0)
        {
            List<Skills> skills = new List<Skills>();

            skills = DbTransaction.DbToList<Skills>("stp_GetSkills", new { isParent= isParent,
                                                                            skillParentID = skillParentID
                                                                            }, true);
            return skills;
        }
    }
}