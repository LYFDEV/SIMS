<%@ WebHandler Language="C#" Class="Handler_UpdateInfo" %>

using System;
using System.Web;
using System.IO;
using SIMS.BLL;

public class Handler_UpdateInfo : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        string path = context.Request.MapPath("UpdateInfo.html");
        string html = File.ReadAllText(path);
        StdInfoBLL sib = new StdInfoBLL();
        string exit = context.Request["textOldName"];
        bool isPost = !string.IsNullOrEmpty(exit);
        if(isPost)
        {
            string textOldName = context.Request["textOldName"];
            string textStdNum = context.Request["textStdNum"];
            string textName = context.Request["textName"];
            string textEmail = context.Request["textEmail"];
            string textPN = context.Request["textPN"];
            if (textOldName!=null&&textStdNum!=null&&textName!=null&&textEmail!=null&&textPN!=null)
            {
                if(sib.UpdateInfo(textOldName,textStdNum,textName,textEmail,textPN)>0)
                {
                    context.Response.Write("<script>alert('创建成功');location.href='Handler_ShowInfo.ashx';</script>");
                }
                else
                {
                    html = html.Replace("@OldName",null).Replace("@StdNum", null).Replace("@Name", null).Replace("@Email", null).Replace("@PN", null);
                }
            }
            else
            {
                context.Response.Write("<script>alert('请将信息填写完整');</script>");
            }

        }
        else
        {
            html = html.Replace("@OldName",null).Replace("@StdNum", null).Replace("@Name", null).Replace("@Email", null).Replace("@PN", null);
        }
        context.Response.Write(html);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}