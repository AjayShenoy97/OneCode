
CREATE PROCEDURE FilterProducts 
	@BrandName nvarchar(30),
	@Cost int,
	@Filter nvarchar(20)
AS
BEGIN
IF(@Filter='Brand')
BEGIN
	SELECT ProductName, BrandName, Cost, ProductImage from Products WHERE BrandName=@BrandName 
END
IF(@Filter='Cost')
BEGIN
	SELECT ProductName, BrandName, Cost, ProductImage from Products WHERE Cost<=@Cost
END
END
GO
