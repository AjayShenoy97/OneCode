
CREATE PROCEDURE BrandCrud 
	@BrandId int,
	@BrandName nvarchar(30),
	@CreatedDate datetime,
	@Brand nvarchar(20)
AS
BEGIN
IF (@Brand='Select')
BEGIN
SELECT BrandName, CreatedDate FROM Brand
END
IF (@Brand='Insert')
BEGIN
	INSERT INTO Brand(BrandName, CreatedDate) 
	VALUES(@BrandName, @CreatedDate)
	SET @BrandId= SCOPE_IDENTITY()
END
IF (@Brand='Delete')
BEGIN
	DELETE FROM Brand WHERE BrandId=@BrandId;
END
END
GO

