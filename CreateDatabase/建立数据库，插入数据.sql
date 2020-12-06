CREATE DATABASE [StdInfo]
USE StdINfo
CREATE TABLE [dbo].[T_Admin] (
    [AdminName] NVARCHAR (24) NOT NULL,
    [Password]  NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([AdminName] ASC, [Password] ASC)
);
CREATE TABLE [dbo].[T_SuperAdmin] (
    [SAdminName] NVARCHAR (24) NOT NULL,
    [SPassword]  NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([SAdminName] ASC)
);
CREATE TABLE [dbo].[T_StdInfo] (
    [StdNum]      NVARCHAR (12) NOT NULL,
    [Name]        NVARCHAR (6)  NOT NULL,
    [Sex]         NVARCHAR (2)  NOT NULL,
    [Nation]      NVARCHAR (10) NOT NULL,
    [E_Mail]      NCHAR (100)   NOT NULL,
    [PhoneNumber] NCHAR (11)    NOT NULL,
    PRIMARY KEY CLUSTERED ([StdNum] ASC, [Name] ASC)
);
INSERT INTO [T_Admin] VALUES('LYFUB','5494326lyfLYF');
INSERT INTO [T_Admin] VALUES('lyifan','5494326lyfLYF');
INSERT INTO [T_SuperAdmin] VALUES('UnicornBeetle','evjplerpl');
INSERT INTO [T_StdInfo] VALUES('181400000001','独角仙','男','汉族','181400000001@qq.com','00000000001');
INSERT INTO [T_StdInfo] VALUES('181400000002','比目鱼','男','汉族','181400000002@qq.com','00000000002');
INSERT INTO [T_StdInfo] VALUES('181400000003','知更鸟','女','汉族','181400000003@qq.com','00000000003');
INSERT INTO [T_StdInfo] VALUES('181400000004','大山雀','男','汉族','181400000004@qq.com','00000000004');
INSERT INTO [T_StdInfo] VALUES('181400000005','变色龙','男','汉族','181400000005@qq.com','00000000005');
INSERT INTO [T_StdInfo] VALUES('181400000006','大斑鸠','女','汉族','181400000006@qq.com','00000000006');
INSERT INTO [T_StdInfo] VALUES('181400000007','负鼠','男','汉族','181400000007@qq.com','00000000007');
INSERT INTO [T_StdInfo] VALUES('181400000008','士官长','男','汉族','181400000008@qq.com','00000000008');
INSERT INTO [T_StdInfo] VALUES('181400000009','科塔娜','女','汉族','181400000009@qq.com','00000000009');
INSERT INTO [T_StdInfo] VALUES('181400000010','普莱斯','男','汉族','181400000010@qq.com','00000000010');
INSERT INTO [T_StdInfo] VALUES('181400000011','肥皂','男','汉族','181400000011@qq.com','00000000011');
INSERT INTO [T_StdInfo] VALUES('181400000012','幽灵','男','汉族','181400000012@qq.com','00000000012');
INSERT INTO [T_StdInfo] VALUES('181400000013','阿泰尔','男','汉族','181400000013@qq.com','00000000013');
INSERT INTO [T_StdInfo] VALUES('181400000014','艾吉奥','男','汉族','181400000014@qq.com','00000000014');
INSERT INTO [T_StdInfo] VALUES('181400000015','艾登','男','汉族','181400000015@qq.com','00000000015');
INSERT INTO [T_StdInfo] VALUES('181400000016','雷蒙','男','汉族','181400000016@qq.com','00000000016');
INSERT INTO [T_StdInfo] VALUES('181400000017','扳手','男','汉族','181400000017@qq.com','00000000017');
INSERT INTO [T_StdInfo] VALUES('181400000018','神风烈士','男','汉族','181400000018@qq.com','00000000018');
INSERT INTO [T_StdInfo] VALUES('181400000019','赞恩','男','汉族','181400000019@qq.com','00000000019');
INSERT INTO [T_StdInfo] VALUES('181400000020','泽塔','男','汉族','181400000020@qq.com','00000000020');
INSERT INTO [T_StdInfo] VALUES('181400003041','李祎凡','男','汉族','3622495140@qq.com','17731857993');
INSERT INTO [T_StdInfo] VALUES('181400003998','测试0','男 ','汉族','181400003998@qq.com','18140000399');
INSERT INTO [T_StdInfo] VALUES('181400003999','测试1','男 ','汉族','181400003999@qq.com','18140000399');
INSERT INTO [T_StdInfo] VALUES('181400004000','测试2','男 ','汉族','181400004000@qq.com','18140000400');