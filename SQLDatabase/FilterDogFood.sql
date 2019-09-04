CREATE PROCEDURE FilterDogFood 
	@BrandName nvarchar(30),
	@Cost int,
	@Quantity int,
	@Filter nvarchar(20)
AS
BEGIN
IF(@Filter='Brand')
BEGIN
		SELECT FoodName, Quantity, Cost, BrandName, FoodImage from DogFood WHERE BrandName=@BrandName 
END
IF(@Filter='Cost')
BEGIN
	SELECT FoodName, Quantity, Cost, BrandName, FoodImage from DogFood WHERE Cost<=@Cost
END
IF(@Filter='Quantity')
BEGIN
	SELECT FoodName, Quantity, Cost, BrandName, FoodImage from DogFood WHERE Quantity=@Quantity
END
END
GO
