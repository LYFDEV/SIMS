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
    public class StdInfoDAL
    {

        //CRUD操作

        //添加数据的方法
        public int AddInfo(string stdNum, string name, string sex, string nation, string e_mail, string pn)
        {
            //拼接SQL语句
            string cmdText = @"INSERT INTO T_PerInfo VALUES(@StdNum,@Name,@Sex,@Nation,@E_Mail,@PhoneNumber)";

            //创建SqlParameter对象，获取参数
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@StdNum", SqlDbType.Char, 12);
            sp[0].Value = stdNum;
            sp[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 6);
            sp[1].Value = name;
            sp[2] = new SqlParameter("@Sex", SqlDbType.NChar, 2);
            sp[2].Value = sex;
            sp[3] = new SqlParameter("@Nation", SqlDbType.NVarChar, 10);
            sp[3].Value = nation;
            sp[4] = new SqlParameter("@E_Mail", SqlDbType.NVarChar, 100);
            sp[4].Value = e_mail;
            sp[5] = new SqlParameter("@PhoneNumber", SqlDbType.Char, 11);
            sp[5].Value = pn;

            //返回影响行数
            return SQLCommand.ExecuteNonQuery(cmdText, sp);
        }

        //删除数据的方法
        public int DeleteInfoByNum(string stdNum)
        {
            //拼接SQL语句
            string cmdText = "DELETE FROM T_PerInfo WHERE StdNum=@Stdnum";

            //创建SqlParameter对象
            SqlParameter sp = new SqlParameter("@Stdnum", SqlDbType.Char, 12);
            sp.Value = stdNum;

            //返回影响行数
            return SQLCommand.ExecuteNonQuery(cmdText, sp);

        }

        //更新数据的方法
        public int UpdatePN(string phoneNumber, string name)
        {
            //拼接SQL语句
            string cmdText = @"UPDATE T_PerInfo SET PhoneNumber=@NewPN WHERE Name=@Name";

            //SqlParameter对象，获取参数“姓名”
            SqlParameter spName = new SqlParameter("@Name", SqlDbType.NVarChar, 6);
            spName.Value = name;

            //SqlParameter对象，获取参数“新电话号码”
            SqlParameter spPN = new SqlParameter("@NewPN", SqlDbType.Char, 11);
            spPN.Value = phoneNumber;

            //返回影响行数
            return SQLCommand.ExecuteNonQuery(cmdText, spPN, spName);

        }

        public int UpdateInfo(string oldName, string stdNum, string name, string e_mail, string pn)
        {
            //拼接SQL语句
            string cmdText = @"UPDATE T_PerInfo SET StdNum=@NewStdNum, Name=@NewName, E_Mail=@NewE_Mail, PhoneNumber=@NewPN WHERE Name=@OldName";

            SqlParameter spStdNum = new SqlParameter("@NewStdNum", SqlDbType.NVarChar, 12);
            spStdNum.Value = stdNum;
            SqlParameter spName = new SqlParameter("@NewName", SqlDbType.NVarChar, 6);
            spName.Value = name;
            SqlParameter spEmail = new SqlParameter("@NewE_Mail", SqlDbType.NChar, 100);
            spEmail.Value = e_mail;
            SqlParameter spPN = new SqlParameter("@NewPN", SqlDbType.Char, 11);
            spPN.Value = pn;
            SqlParameter spOldName = new SqlParameter("@OldName", SqlDbType.NVarChar, 6);
            spOldName.Value = oldName;

            return SQLCommand.ExecuteNonQuery(cmdText, spStdNum, spName, spEmail, spPN, spOldName);
        }

        //查询数据的方法
        public StdInfoModel GetInfoByNum(string stdNum)
        {
            string cmdText = @"SELECT * FROM T_PerInfo WHERE StdNum=@StdNum";
            SqlParameter sp = new SqlParameter("@StdNum", SqlDbType.Char, 12);
            sp.Value = stdNum;
            DataSet ds = SQLCommand.GetDataSet(cmdText, sp);
            StdInfoDAL pd = new StdInfoDAL();
            if (ds.Tables.Count > 0)
            {
                return pd.DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public StdInfoModel DataRowToModel(DataRow dr)
        {
            StdInfoModel m = null;

            if (dr != null)
            {
                m = new StdInfoModel();
                m.StdNum = dr["StdNum"].ToString();
                m.Name = dr["Name"].ToString();
                m.Sex = dr["Sex"].ToString();
                m.Nation = dr["Nation"].ToString();
                m.E_Mail = dr["E_Mail"].ToString();
                m.PhoneNumber = dr["PhoneNumber"].ToString();
            }

            return m;
        }

        //提取所有学生的信息
        public List<StdInfoModel> GetAllInformation()
        {
            string cmd = "SELECT [StdNum], [Name], [Sex], [Nation], [E_Mail], [PhoneNumber] FROM [T_PerInfo]";
            DataTable dt = SQLCommand.ExecuteQuery(cmd);

            return DateToList(dt);
        }

        private List<StdInfoModel> DateToList(DataTable dt)
        {
            List<StdInfoModel> lSid = new List<StdInfoModel>();
            foreach (DataRow dr in dt.Rows)
            {
                StdInfoModel sim = new StdInfoModel();
                sim.StdNum = dr["StdNum"].ToString();
                sim.Name = dr["Name"].ToString();
                sim.Sex = dr["Sex"].ToString();
                sim.Nation = dr["Nation"].ToString();
                sim.E_Mail = dr["E_Mail"].ToString();
                sim.PhoneNumber = dr["PhoneNumber"].ToString();
                lSid.Add(sim);
            }
            return lSid;
        }
    }
}