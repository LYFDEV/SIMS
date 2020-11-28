﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMS.DAL;
using SIMS.Model;

namespace SIMS.BLL
{
    public class SuperAdminInfoBLL
    {
        private SuperAdminDAL sad = new SuperAdminDAL();

        //查询超级管理员信息
        public List<SuperAdminInfoModel> GetSuperAdminInfo()
        {
            return sad.GetSuperAdminInfo();
        }
    }
}