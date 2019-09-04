
CREATE PROCEDURE ProductOrderCrud
	@ProductOrderId int,
	@CustId int,
	@ProductId int,
	@ProductOrderStatus nvarchar(20),
	@ProductOrderDate date,
	@CancelDate date,
	@ProductOrder nvarchar
AS
BEGIN
	IF (@ProductOrder='Select')
	BEGIN
	SELECT CustId, ProductId, ProductOrderStatus, ProductOrderDate, CancelDate From ProductOrder
	END
	IF (@ProductOrder='Insert')
	BEGIN
		INSERT INTO ProductOrder(CustId, ProductId, ProductOrderStatus, ProductOrderDate) 
		VALUES(@CustId, @ProductId, @ProductOrderStatus, @ProductOrderDate)
		SET @ProductOrderId = SCOPE_IDENTITY()
	END
	IF (@ProductOrder='Update')
	BEGIN
		UPDATE ProductOrder SET CustId=@CustId, ProductId=@ProductId, ProductOrderStatus=@ProductOrderStatus, CancelDate=@CancelDate WHERE ProductOrderId=@ProductOrderId;
	END
	IF (@ProductOrder='Delete')
	BEGIN
		DELETE FROM ProductOrder WHERE ProductOrderId=@ProductOrderId;
	END
END
GO