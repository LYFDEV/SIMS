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
        public List<SuperAdminInfoModel> GetSuperAdminInfo()
        {
            string cmd = "SELECT [SAdminName], [SPassword] FROM [T_SuperAdmin]";
            DataTable dt = SQLCommand.ExecuteQuery(cmd);

            return DateToList(dt);
        }
        private List<SuperAdminInfoModel> DateToList(DataTable dt)
        {
            List<SuperAdminInfoModel> lSaim = new List<SuperAdminInfoModel>();
            foreach (DataRow dr in dt.Rows)
            {
                SuperAdminInfoModel saim = new SuperAdminInfoModel();
                saim.SAdminName = dr["SAdminName"].ToString();
                saim.SPassword = dr["SPassword"].ToString();
                lSaim.Add(saim);
            }
            return lSaim;
        }
    }
}
