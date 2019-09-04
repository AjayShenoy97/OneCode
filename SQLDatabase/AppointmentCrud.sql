CREATE PROCEDURE AppointmentCrud 
	@AppointmentId int,
	@CustId int,	
	@DogId int,
	@AppointmentStatus nvarchar(20),
	@AppointmentDate date,
	@CancelDate date,
	@CreatedDate datetime,
	@UpdateDate datetime,
	@Appointment nvarchar(20)
AS
BEGIN
	IF (@Appointment='Select')
	BEGIN
	SELECT CustId, DogId, AppointmentStatus, AppointmentDate, CancelDate, CreatedDate, UpdateDate From Appointment
	END
	IF (@Appointment='Insert')
	BEGIN
		INSERT INTO Appointment(CustId, DogId, AppointmentStatus, AppointmentDate, CreatedDate) 
		VALUES(@CustId, @DogId, @AppointmentStatus, @AppointmentDate, @CreatedDate)
		SET @AppointmentId = SCOPE_IDENTITY()
	END
	IF (@Appointment='Update')
	BEGIN
		UPDATE Appointment SET CustId=@CustId, DogId=@DogId, AppointmentStatus=@AppointmentStatus, UpdateDate=@UpdateDate, CancelDate=@CancelDate WHERE AppointmentId=@AppointmentId;
	END
	IF (@Appointment='Delete')
	BEGIN
		DELETE FROM Appointment WHERE AppointmentId=@AppointmentId;
	END
END
GO
