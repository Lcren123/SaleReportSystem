USE [WebSalesDb]
GO
/****** Object:  StoredProcedure [dbo].[userProfileManagement]    Script Date: 5/6/2023 11:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[userProfileManagement]
	-- Add the parameters for the stored procedure here
	@loginId nvarchar(50),
	@userName nvarchar(200),
	@password nvarchar(50),
	@userRole nvarchar(50),
	@manager nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
CREATE TABLE temptable (
    loginId nvarchar(50),
	userName nvarchar(200),
	password nvarchar(50),
	userRole nvarchar(50),
	manager nvarchar(50)
);
INSERT temptable VALUES(@loginId, @userName, @password, @userRole, @manager);

Merge dbo.UserProfile AS Tar
Using temptable AS Src
ON Src.loginId = Tar.loginId

WHEN MATCHED
THEN
UPDATE SET Tar.userName = @userName, Tar.password = @password, Tar.userRole = @userRole, Tar.reportingManager = @manager
-- WHERE Tar.loginId = @loginId
WHEN NOT MATCHED
THEN
    -- Insert statements for procedure here
INSERT (loginId,userName,password,userRole,reportingManager) 
VALUES(@loginId, @userName, @password, @userRole, @manager);
END
