# 学生信息管理系统

## 介绍
使用ASP.NET与C#、HTML等语言编写的网站应用，用于管理学生基本信息

### 应用架构
#### 软件使用了三层结构+网站UI实现增删改查功能。
1.  SIMS_WebSite(ASP.NET网站)
    * Login.aspx            _Web窗体 实现登录管理员用户以及注册的功能_
    * Register.aspx         _Web窗体 实现用超级管理员用户权限注册管理员用户的功能_
    * CreateStdInfo.aspx    _Web窗体 实现创建学生信息的功能_
    * RetrieveStdInfo.aspx  _Web窗体 实现查询学生信息的功能_
    * UpdateStdInfo.aspx    _Web窗体 实现更新学生信息的功能_
    * DeleteStdInfo.aspx    _Web窗体 实现删除学生信息的功能_
    * StdInfo.html          _HTML页面用于显示学生信息_
    * Handler_ShowStdInfo.ashx _一般处理程序 用于在StdInfo.html中显示学生信息_
2.  SIMSBLL(业务逻辑层)
    * StdInfoBLL.cs         _学生信息BLL类 调用DAL层方法实现对学生信息增删改查的功能_
    * AdminInfoBLL.cs       _管理员信息BLL类 调用DAL层方法实现对管理员信息增删查的功能_
    * SuperAdminInfoBLL.cs  _超级管理员BLL类 调用DAL层方法实现查询超级管理员信息的功能_
3.  SIMSDAL(数据访问层)
    * StdInfoDAL.cs         _学生信息DAL类 对数据库[T_StdInfo]表进行增删改查_
    * AdminInfoDAL.cs       _管理员信息DAL类 对数据库[T_Admin]表进行增删查_
    * SuperAdminInfoDAL.cs  _超级管理员DAL类 对数据库[T_SuperAdmin]进行查询_
    * SQLCommand.cs         _SQL语句方法类，实现对数据库增删改查的功能_
4.  SIMSModel(对象关系映射层)
    * StdInfo.cs            _学生信息Model类 用于提取学生信息的类_
    * AdminInfo.cs          _管理员信息Model类 用于提取管理员信息的类_
    * SuperAdminInfoDAL.cs  _超级管理员Model类 用于提取超级管理员信息的类_

### 数据库说明
#### 使用SQL Server 2019 Express数据库以及SSMS集成环境对数据库进行配置与管理
1.  数据库[StdInfo]
2.  数据库表
    * 学生信息表[T_StdInfo]
    * 管理员信息表[T_Admin]
    * 超级管理员信息表[T_SuperAdmin]
3.  学生信息包括：_学号_、_姓名_、_性别_、_民族_、_电子邮箱_、_联系方式_。
4.  管理员信息包括：_用户名_、_密码_。
5.  超级管理员信息包括：_用户名_、_密码_。
    >暂时不支持对超级管理员用户信息的注册、修改、删除以及更新。

### 使用说明

1.  执行查询[SIMS\CreateDatabase]目录下的"_建立数据库，插入数据.sql_"文件可以建立数据库并插入数据
2.  更改连接字符串。
3.  生成解决方案以及调试。

### GitHub仓库

1.  你可以在 [https://github.com/LYFDEV/SIMS](https://github.com/LYFDEV/SIMS) 这个地址来下载该项目。
2.  你可以通过QQ邮箱：_lyfcoder@gmail.com_ 联系我。 
