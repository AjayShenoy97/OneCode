
CREATE PROCEDURE GetPassword 
	@CustName nvarchar(30),
	@EmailId nvarchar(30),
	@Password nvarchar(20)
AS
BEGIN
	SELECT @Password=Password FROM Customer WHERE CustName=@CustName AND EmailId=@EmailId
END
GO
