﻿<%@ WebHandler Language="C#" Class="Handler_ShowInfo" %>

using System;
using System.Web;
using System.IO;
using System.Text;
using SIMS.BLL;
using SIMS.Model;
using System.Collections.Generic;

public class Handler_ShowInfo : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        string path = context.Request.MapPath("Index.html");
        string html = File.ReadAllText(path);
        StdInfoBLL sib = new StdInfoBLL();
        List<StdInfoModel> lSim = sib.GetAllInformation();
        StringBuilder sb = new StringBuilder();
        sb.Append("<table  id='T_StdInfo' cellspacing='0' cellpadding='0'>");
        sb.Append("<tr><th>学号</th><th>姓名</th><th>性别</th><th>民族</th><th>电子邮箱</th><th>联系方式</th><th>操作</th></tr>");
        if(lSim!=null)
        {
            for(int i = 0; i < lSim.Count; i++)
            {
                StdInfoModel sim = lSim[i];
                sb.Append("<tr>");
                sb.Append("<td>" + sim.StdNum + "</td>").Append("<td>" + sim.Name + "</td>").Append("<td>" + sim.Sex + "</td>");
                sb.Append("<td>" + sim.Nation + "</td>").Append("<td>" + sim.E_Mail + "</td>").Append("<td>" + sim.PhoneNumber + "</td>");
                sb.Append("<td><a href='Handler_UpdateInfo.ashx?StdNum=" + sim.StdNum + "'>编辑</a> <a href='Handler_DeleteInfo.ashx?StdNum=" + sim.StdNum + "' onclick='return confirm(\"确定要删除吗？\")'>删除</a></td>");
                sb.Append("</tr>");
            }
        }

        sb.Append("</table>");
        html = html.Replace("@T_StdInfo", sb.ToString());
        context.Response.Write(html);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }
}