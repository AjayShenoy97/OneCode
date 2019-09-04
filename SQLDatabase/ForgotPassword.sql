
CREATE PROCEDURE ForgotPassword
	@CustName nvarchar(30),
	@EmailId nvarchar(30)
AS
BEGIN
	SELECT Password from Customer WHERE CustName=@CustName AND EmailId=@EmailId
END
GO
