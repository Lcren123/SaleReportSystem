USE [WebSalesDb]
GO
/****** Object:  StoredProcedure [dbo].[loginAuthorization]    Script Date: 5/6/2023 11:39:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[loginAuthorization]
	-- Add the parameters for the stored procedure here
	@userName nvarchar(200),
	@password nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT loginId FROM UserProfile WHERE userName = @userName AND password = @password
END
