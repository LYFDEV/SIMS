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
    //数据访问层
    public class AdminInfoDAL
    {
        //CRUD操作

        //创建管理员账户的方法
        public int AddAdmin(string userName, string password)
        {
            //拼接SQL语句
            string cmdText = @"INSERT INTO T_Admin VALUES(@AdminName,@Password)";

            //创建SqlParameter对象，获取参数
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@AdminName", SqlDbType.NVarChar, 24);
            sp[0].Value = userName;
            sp[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 20);
            sp[1].Value = password;

            //返回影响行数
            return SQLCommand.ExecuteNonQuery(cmdText, sp);
        }

        //删除管理员账户的方法
        public int DeleteAddmin(string userName)
        {
            //拼接SQL语句
            string cmdText = "DELETE FROM T_Admin WHERE AdminName=@AdminName";

            //创建SqlParameter对象
            SqlParameter sp = new SqlParameter("@AdminName", SqlDbType.NVarChar, 24);
            sp.Value = userName;

            //返回影响行数
            return SQLCommand.ExecuteNonQuery(cmdText, sp);
        }

        //查询管理员账户信息的方法
        public List<AdminInfoModel> GetAdminInfo()
        {
            string cmd = "SELECT [AdminName], [Password] FROM [T_Admin]";
            DataTable dt = SQLCommand.ExecuteQuery(cmd);

            return DateToList(dt);
        }
        private List<AdminInfoModel> DateToList(DataTable dt)
        {
            List<AdminInfoModel> lAim = new List<AdminInfoModel>();
            foreach (DataRow dr in dt.Rows)
            {
                AdminInfoModel aim = new AdminInfoModel();
                aim.AdminName = dr["AdminName"].ToString();
                aim.Password = dr["Password"].ToString();
                lAim.Add(aim);
            }
            return lAim;
        }
    }
}