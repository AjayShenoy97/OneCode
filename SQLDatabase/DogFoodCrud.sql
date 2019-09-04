
CREATE PROCEDURE DogFoodCrud
	@FoodId int,
	@FoodName nvarchar(30),
	@Quantity nvarchar(20),
	@Cost int,
	@BrandId nvarchar(30),
	@Stock int,
	@FoodImage varbinary(max),
	@CreatedDate datetime,
	@UpdateDate datetime,
	@DogFood nvarchar(20)
AS
BEGIN
	IF (@DogFood='Select')
	BEGIN
	SELECT FoodName, Quantity, Cost, BrandId, Stock, FoodImage, CreatedDate From DogFood
	END
	IF (@DogFood='Insert')
	BEGIN
		INSERT INTO DogFood(FoodName, Quantity, Cost, BrandId, Stock, FoodImage, CreatedDate) 
		VALUES(@FoodName, @Quantity, @Cost, @BrandId, @Stock, @FoodImage, @CreatedDate)
		SET @FoodId = SCOPE_IDENTITY()
	END
	IF (@DogFood='Update')
	BEGIN
		UPDATE DogFood SET FoodName=@FoodName, Quantity=@Quantity, Cost=@Cost, BrandId=@BrandId, Stock=@Stock, FoodImage=@FoodImage, UpdateDate=@UpdateDate WHERE FoodId=@FoodId;
	END
	IF (@DogFood='Delete')
	BEGIN
		DELETE FROM DogFood WHERE FoodId=@FoodId;
	END
END
GO
