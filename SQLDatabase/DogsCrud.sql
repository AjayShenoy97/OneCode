
CREATE PROCEDURE DogsCrud
	@DogId int, 
	@DogName nvarchar(20),
	@Breed nvarchar(20),
	@Gender nvarchar(20),
	@DogImage varbinary(max),
	@CreatedDate datetime,
	@UpdateDate datetime,
	@Dog nvarchar(20)
AS
BEGIN
IF (@Dog='Select')
BEGIN
SELECT DogName, Breed, Gender, DogImage, CreatedDate FROM Dogs
END
IF (@Dog='Insert')
BEGIN
	INSERT INTO Dogs(DogName, Breed, Gender, DogImage, CreatedDate) 
	VALUES(@DogName, @Breed, @Gender, @DogImage, @CreatedDate)
	SET @DogId = SCOPE_IDENTITY()
END
IF (@Dog='Update')
BEGIN
	UPDATE Dogs SET DogName=@DogName, Breed=@Breed,Gender=@Gender,DogImage=@DogImage, UpdateDate=@UpdateDate WHERE DogId=@DogId;
END
IF (@Dog='Delete')
BEGIN
	DELETE FROM Dogs WHERE DogId=@DogId;
END
END
GO
