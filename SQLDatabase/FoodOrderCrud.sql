
CREATE PROCEDURE FoodOrderCrud 
	@FoodOrderId int,
	@CustId int,
	@FoodId int,
	@FoodOrderStatus nvarchar(20),
	@FoodOrderDate date,
	@CancelDate date,
	@FoodOrder nvarchar
AS
BEGIN
	IF (@FoodOrderId='Select')
	BEGIN
	SELECT CustId, FoodId, FoodOrderStatus, FoodOrderDate, CancelDate From FoodOrder
	END
	IF (@FoodOrderId='Insert')
	BEGIN
		INSERT INTO FoodOrder(CustId, FoodId, FoodOrderStatus, FoodOrderDate) 
		VALUES(@CustId, @FoodId, @FoodOrderStatus, @FoodOrderDate)
		SET @FoodOrderId = SCOPE_IDENTITY()
	END
	IF (@FoodOrderId='Update')
	BEGIN
		UPDATE FoodOrder SET CustId=@CustId, FoodId=@FoodId, FoodOrderStatus=@FoodOrderStatus, CancelDate=@CancelDate WHERE FoodOrderId=@FoodOrderId;
	END
	IF (@FoodOrderId='Delete')
	BEGIN
		DELETE FROM FoodOrder WHERE FoodOrderId=@FoodOrderId;
	END
END
GO
