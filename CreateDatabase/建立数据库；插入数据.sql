CREATE DATABASE [StdINfo]
USE StdINfo
CREATE TABLE [dbo].[T_Admin](
	[UserName]	NVARCHAR(24)	NOT NULL,
	[Password]	NVARCHAR(20)	NOT NULL,
	PRIMARY KEY([UserName],[Password]),
)
CREATE TABLE [dbo].[T_SuperAdmin]
(
	[SAdminName] NVARCHAR(24) NOT NULL , 
    [SPassword] NCHAR(20) NOT NULL, 
    PRIMARY KEY ([SAdminName])
)
INSERT INTO [T_Admin] VALUES('LYFUB','5494326lyfLYF');
INSERT INTO [T_Admin] VALUES('lyifan','5494326lyfLYF');
INSERT INTO [T_SuperAdmin] VALUES('UnicornBeetle','evjplerpl');