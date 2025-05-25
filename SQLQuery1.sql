USE [p2755691]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblCustomer_FilterByCustomerId]
		@CustomerId = 1

SELECT	@return_value as 'Return Value'

GO
