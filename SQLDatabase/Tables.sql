---------------- CREATE TABLES -------------------------

CREATE TABLE Customer(
CustId int PRIMARY KEY IDENTITY,
CustName nvarchar(30) not null,
Contact nvarchar(20) not null,
Landmark nvarchar(30),
City nvarchar(20) not null,
PinCode int not null,
State nvarchar(20) not null,
EmailId nvarchar(30) not null,
Password nvarchar(20) not null,
CreatedDate datetime not null,
UpdateDate datetime
)


CREATE TABLE Dogs(
DogId int PRIMARY KEY IDENTITY,
DogName nvarchar(20) not null,
Breed nvarchar(20) not null,
Gender nvarchar(20) not null,
DogImage varbinary(max) not null,
CreatedDate datetime not null,
UpdateDate datetime
)

CREATE TABLE Products(
ProductId int PRIMARY KEY IDENTITY,
ProductName nvarchar(30) not null,
BrandName nvarchar(30) not null
FOREIGN KEY (BrandName) REFERENCES Brand(BrandName),
Cost int not null,
Stock int not null,
ProductImage varbinary(max) not null,
CreatedDate datetime not null,
UpdateDate datetime
)


CREATE TABLE DogFood(
FoodId int PRIMARY KEY IDENTITY,
FoodName nvarchar(30) not null,
Quantity nvarchar(20) not null,
Cost int not null,
BrandName nvarchar(30) not null
FOREIGN KEY (BrandName) REFERENCES Brand(BrandName),
Stock int not null,
FoodImage varbinary(max) not null,
CreatedDate datetime not null,
UpdateDate datetime
)

CREATE TABLE Appointment(
AppointmentId int PRIMARY KEY IDENTITY,
CustId int not null
FOREIGN KEY (CustId) REFERENCES Customer(CustId),
DogId int not null
FOREIGN KEY (DogId) REFERENCES Dogs(DogId),
AppointmentStatus nvarchar(20) not null,
AppointmentDate date not null,
CancelDate date,
CreatedDate datetime not null,
UpdateDate datetime
)

CREATE TABLE ProductOrder(
ProductOrderId int PRIMARY KEY IDENTITY,
CustId int not null
FOREIGN KEY (CustId) REFERENCES Customer(CustId),
ProductId int not null
FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
ProductOrderStatus nvarchar(20) not null,
ProductOrderDate date not null,
CancelDate date
)

CREATE TABLE FoodOrder(
FoodOrderId int PRIMARY KEY IDENTITY,
CustId int not null
FOREIGN KEY (CustId) REFERENCES Customer(CustId),
FoodId int not null
FOREIGN KEY (FoodId) REFERENCES DogFood(FoodId),
FoodOrderStatus nvarchar(20) not null,
FoodOrderDate date not null,
CancelDate date
)

CREATE TABLE Brand(
BrandId int IDENTITY,
BrandName nvarchar(30) PRIMARY KEY,
CreatedDate datetime not null
)

CREATE TABLE Admin(
AdminId int PRIMARY KEY IDENTITY,
AdminName nvarchar(30) not null,
AdminContact nvarchar(30) not null,
EmailId nvarchar(30) not null,
Password nvarchar(30) not null, 
CreatedDate datetime not null,
UpdateDate datetime 
)

Drop table FoodOrder
Drop table ProductOrder
Drop table DogFood
Drop table Products
Drop table Brand