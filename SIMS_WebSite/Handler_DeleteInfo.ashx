<%@ WebHandler Language="C#" Class="Handler_DeleteInfo" %>

using System;
using System.Web;
using SIMS.BLL;

public class Handler_DeleteInfo : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        string targetStdNum=context.Request.QueryString["StdNum"];
        StdInfoBLL sib = new StdInfoBLL();
        if(sib.DeleteInfoByNum(targetStdNum)>0)
        {
            context.Response.Write("<script>alert('删除成功');location.href='Handler_ShowInfo.ashx';</script>");
        }
        else
        {

            context.Response.Write("<script>alert('删除失败');location.href='Handler_ShowInfo.ashx';</script>");
        }
    }
    public bool IsReusable {
        get {
            return false;
        }
    }

}