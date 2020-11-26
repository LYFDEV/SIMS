<%@ WebHandler Language="C#" Class="Handler_CreateInfo" %>

using System;
using System.Web;
using System.IO;
using SIMS.BLL;

public class Handler_CreateInfo : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        string path = context.Request.MapPath("CreateInfo.html");
        string html = File.ReadAllText(path);
        StdInfoBLL sib = new StdInfoBLL();
        string exit = context.Request["textStdNum"];
        bool isPost = string.IsNullOrEmpty(exit);
        if(isPost)
        {
            string textStdNum = context.Request["textStdNum"];
            string textName = context.Request["textName"];
            string textSex = context.Request["textSex"];
            string textNation = context.Request["textNation"];
            string textEmail = context.Request["textEmail"];
            string textPN = context.Request["textPN"];
            if(textStdNum!=null&&textName!=null&&textSex!=null&&textNation!=null&&textEmail!=null&&textPN!=null)
            {
                if(sib.AddInfo(textStdNum,textName,textSex,textNation,textEmail,textPN)>0)
                {
                    context.Response.Write("<script>alert('更新成功');location.href='Handler_ShowInfo.ashx';</script>");
                }
                else
                {
                    html = html.Replace("@StdNum", null).Replace("@Name", null).Replace("@Sex", null).Replace("@Nation", null).Replace("@Email", null).Replace("@PN", null);
                }
            }
            else
            {
                context.Response.Write("<script>alert('请将信息填写完整');</script>");
            }

        }
        else
        {
            html = html.Replace("@StdNum", null).Replace("@Name", null).Replace("@Sex", null).Replace("@Nation", null).Replace("@Email", null).Replace("@PN", null);
        }
        context.Response.Write(html);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }
}