
CREATE PROCEDURE InsertAdmin
	@AdminName nvarchar(30),
	@AdminContact nvarchar(30),
	@EmailId nvarchar(30),
	@Password nvarchar(30), 
	@CreatedDate datetime
AS
BEGIN
	
	INSERT INTO Admin(AdminName, AdminContact, EmailId, Password, CreatedDate) 
	VALUES(@AdminName, @AdminContact, @EmailId, @Password, @CreatedDate)
	
END
GO
