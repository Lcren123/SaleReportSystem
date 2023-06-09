USE [WebSalesDb]
GO
/****** Object:  StoredProcedure [dbo].[YearlyReportSP]    Script Date: 5/6/2023 11:41:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[YearlyReportSP]
	-- Add the parameters for the stored procedure here
	@managerId nvarchar(50),
	@year int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT SUM(SalesTransaction.amount)AS Amount, MONTH(SalesTransaction.SalesDate) AS Month FROM dbo.SalesTransaction JOIN UserProfile 
	ON UserProfile.loginId = SalesTransaction.UserId 
	WHERE UserProfile.reportingManager = @managerId AND YEAR(SalesTransaction.SalesDate) = @year 
	GROUP BY MONTH(SalesTransaction.SalesDate)
END
