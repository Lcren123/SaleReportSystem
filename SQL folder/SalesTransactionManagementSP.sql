USE [WebSalesDb]
GO
/****** Object:  StoredProcedure [dbo].[salesTransactionManagement]    Script Date: 5/6/2023 11:39:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[salesTransactionManagement]
	-- Add the parameters for the stored procedure here
	@temptable SalesTranscationTempTable Readonly
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

Merge dbo.SalesTransaction AS Tar
Using @temptable AS Src
ON Src.saleId = Tar.saleId

WHEN MATCHED AND EXISTS(
    SELECT Src.saleId, Src.salesItem, Src.salesDate, Src.userId, Src.amount,Src.updatedDate, Src.[Status]
    EXCEPT
    SELECT Tar.saleId, Tar.salesItem, Tar.salesDate, Tar.userId, Tar.amount,Tar.updatedDate, Tar.[Status]
)
THEN
UPDATE SET Tar.salesItem = Src.salesItem, Tar.salesDate = Src.salesDate, Tar.userId = Src.userId, Tar.amount = Src.amount, Tar.updatedDate = GETDATE(), Tar.[Status] = Src.[Status]
-- WHERE Tar.loginId = @loginId
WHEN NOT MATCHED
THEN
    -- Insert statements for procedure here
INSERT (saleId, salesItem, salesDate, userId, amount, updatedDate, [Status]) 
VALUES(Src.saleId, Src.salesItem, Src.salesDate, Src.userId, Src.amount,Src.updatedDate, Src.[Status]);
END
