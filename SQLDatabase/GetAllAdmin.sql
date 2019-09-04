
CREATE PROCEDURE GetAllAdmin
AS
BEGIN
	SELECT AdminName, AdminContact, EmailId, Password, CreatedDate FROM Admin
END
GO
