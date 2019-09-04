
CREATE PROCEDURE ValidateUser
	@EmailId nvarchar(30),
	@Password nvarchar(20),
	@User nvarchar(20)
AS
BEGIN
IF(@User='Customer')
BEGIN
	SELECT EmailId, Password FROM Customer WHERE EmailId=@EmailId AND Password=@Password
END
IF(@User='Admin')
BEGIN
	SELECT EmailId, Password FROM Admin WHERE EmailId=@EmailId AND Password=@Password
END
END
GO
