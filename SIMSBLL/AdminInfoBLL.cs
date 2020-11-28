using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMS.DAL;
using SIMS.Model;

namespace SIMS.BLL
{
    public class AdminInfoBLL
    {
        private AdminInfoDAL aid = new AdminInfoDAL();

        //创建管理员
        public int AddAdmin(string adminName, string password)
        {
            return aid.AddAdmin(adminName, password);
        }

        //删除管理员
        public int DeleteAddmin(string userName)
        {
            return aid.DeleteAddmin(userName);
        }

        //提取管理员信息
        public List<AdminInfoModel> GetAdminInfon()
        {
            return aid.GetAdminInfo();
        }
    }
}
