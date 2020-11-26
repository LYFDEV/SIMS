using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMS.DAL;
using SIMS.Model;

namespace SIMS.BLL
{
    public class StdInfoBLL
    {
        //创建PerInfo_DAL对象
        private StdInfoDAL sid = new StdInfoDAL();

        //提取所有学生的信息
        public List<StdInfoModel> GetAllInformation()
        {
            return sid.GetAllInformation();
        }

        //添加数据
        public int AddInfo(string stdNum, string name, string sex, string nation, string e_mail, string pn)
        {
            return sid.AddInfo(stdNum, name, sex, nation, e_mail, pn);
        }

        //删除数据
        public int DeleteInfoByNum(string stdNum)
        {
            return sid.DeleteInfoByNum(stdNum);
        }

        //更新数据
        public int UpdatePN(string phoneNumber, string name)
        {
            return sid.UpdatePN(phoneNumber, name);
        }

        public int UpdateInfo(string oldName, string stdNum, string name, string e_mail, string pn)
        {
            return sid.UpdateInfo(oldName, stdNum, name, e_mail, pn);
        }
        //查询数据
        public StdInfoModel GetInfoByNum(string stdNum)
        {
            return sid.GetInfoByNum(stdNum);
        }
    }
}
