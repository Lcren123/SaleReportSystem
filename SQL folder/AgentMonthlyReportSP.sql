USE [WebSalesDb]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgentMonthlyReportSP]
	-- Add the parameters for the stored procedure here
	@agentId nvarchar(50),
	@month int,
	@year int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT SUM(SalesTransaction.amount)AS Amount, UserProfile.userName AS Agent 
	FROM SalesTransaction 
	JOIN UserProfile ON UserProfile.loginId = SalesTransaction.UserId
	WHERE SalesTransaction.UserId = @agentId AND MONTH(SalesDate) = @month AND YEAR(SalesDate) = @year
	GROUP BY UserProfile.userName
END
