using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIMS.BLL;
using SIMS.Model;

public partial class RetrieveStdInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //listBox_Result.Items.Add("此列表框显示查询结果");
        //listBox_Result.Items.Add("1814XXXXXXXX/姓名/性别/民族/xxxxxxxxxxx@qq.com/联系方式xxxxxxxxxxx");
    }


    protected void btn_Retrieve_Click(object sender, EventArgs e)
    {
        StdInfoBLL sib = new StdInfoBLL();
        List<StdInfoModel> lSim = sib.GetAllInformation();
        bool isStdExit = false;
        if (tb_StdNum.Text!="")   //信息完整
        {
            for(int i = 0; i<lSim.Count; i++)
            {
                if (tb_StdNum.Text == lSim[i].StdNum)
                    isStdExit = true;
            }
            if (isStdExit)   //学生存在
            {
                StdInfoModel sim = sib.GetInfoByNum(tb_StdNum.Text);
                string result = $"{sim.StdNum}/{sim.Name}/{sim.Sex}/{sim.Nation}/{sim.E_Mail}/{sim.PhoneNumber}";
                listBox_Result.Items.Add(result);
                tb_StdNum.Text = "";
            }
            else    //学生不存在
            {
                Response.Write(@"<script>alert('查无此人');</script>");
            }
        }
        else    //信息不完整
        {
            Response.Write(@"<script>alert('请输入学号');</script>");
        }
    }

    protected void btn_Clear_Click(object sender, EventArgs e)
    {
        tb_StdNum.Text = "";
    }

    protected void btn_ClearResult_Click(object sender, EventArgs e)
    {
        listBox_Result.Items.Clear();
    }
}