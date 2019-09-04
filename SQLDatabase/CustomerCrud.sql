
CREATE PROCEDURE CustomerCrud 
	@CustId int,
	@CustName nvarchar(30),
	@Contact nvarchar(20),
	@Landmark nvarchar(30),
	@City nvarchar(20),
	@PinCode int,
	@State nvarchar(20),
	@EmailId nvarchar(30),
	@Password nvarchar(20),
	@CreatedDate datetime,
	@UpdateDate datetime,
	@Customer nvarchar(20)
	
AS
BEGIN
IF (@Customer='Select')
BEGIN
SELECT CustName, Contact, Landmark, City, PinCode, State, EmailId, CreatedDate FROM Customer
END
IF (@Customer='Insert')
BEGIN
	INSERT INTO Customer(CustName,Contact,Landmark,City,PinCode,State,EmailId,Password,CreatedDate) 
	VALUES(@CustName, @Contact, @Landmark, @City, @PinCode, @State, @EmailId, @Password, @CreatedDate)
	SET @CustId= SCOPE_IDENTITY()
END
IF (@Customer='Update')
BEGIN
	UPDATE Customer SET CustName=@CustName, Contact=@Contact,Landmark=@Landmark,City=@City,PinCode=@PinCode, State=@State,EmailId=@EmailId, Password=@Password, UpdateDate=@UpdateDate WHERE CustId=@CustId;
END
IF (@Customer='Delete')
BEGIN
	DELETE FROM Customer WHERE CustId=@CustId
END
END
GO