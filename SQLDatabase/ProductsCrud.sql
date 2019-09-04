
CREATE PROCEDURE ProductsCrud
	@ProductId int,
	@ProductName nvarchar(30),
	@BrandId nvarchar(30),
	@Stock int,
	@Cost int,
	@ProductImage varbinary(max),
	@CreatedDate datetime,
	@UpdateDate datetime,
	@Product nvarchar(20)
AS
BEGIN
	IF (@Product='Select')
	BEGIN
	SELECT ProductName, BrandId, Stock, Cost, ProductImage, CreatedDate From Products
	END
	IF (@Product='Insert')
	BEGIN
		INSERT INTO Products(ProductName, BrandId, Stock, Cost, ProductImage, CreatedDate) 
		VALUES(@ProductName, @BrandId, @Stock, @Cost, @ProductImage, @CreatedDate)
		SET @ProductId = SCOPE_IDENTITY()
	END
	IF (@Product='Update')
	BEGIN
		UPDATE Products SET ProductName=@ProductName, BrandId=@BrandId, Stock=@Stock, Cost=@Cost, ProductImage=@ProductImage, UpdateDate=@UpdateDate WHERE ProductId=@ProductId;
	END
	IF (@Product='Delete')
	BEGIN
		DELETE FROM Products WHERE ProductId=@ProductId;
	END
END
GO
