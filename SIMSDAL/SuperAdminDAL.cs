using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMS.Model;
using System.Data;
using System.Data.SqlClient;

namespace SIMS.DAL
{
    public class SuperAdminDAL
    {
        //查询超级管理员账户信息的方法
        public List<SuperAdminModel> GetSuperAdmin()
        {
            string cmd = "SELECT [SAdminName], [SPassword] FROM [T_SuperAdmin]";
            DataTable dt = SQLCommand.ExecuteQuery(cmd);

            return DateToList(dt);
        }
        private List<SuperAdminModel> DateToList(DataTable dt)
        {
            List<SuperAdminModel> lSam = new List<SuperAdminModel>();
            foreach (DataRow dr in dt.Rows)
            {
                SuperAdminModel sam = new SuperAdminModel();
                sam.SAdminName = dr["SAdminName"].ToString();
                sam.SPassword = dr["SPassword"].ToString();
                lSam.Add(sam);
            }
            return lSam;
        }
    }
}
