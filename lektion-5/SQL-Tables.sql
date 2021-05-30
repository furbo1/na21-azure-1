CREATE TABLE Customers (
	Id int not null identity(1,1) primary key,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null
)

CREATE TABLE Products (
	Id int not null identity primary key,
	ProductName nvarchar(50) not null,
	Description nvarchar(max) null,
	Price money null
)
GO

CREATE TABLE Orders (
	Id int not null identity primary key,
	CustomerId int not null references Customers(Id),
	OrderDate datetime not null
)
GO

CREATE TABLE OrderLine (
	OrderId int not null references Orders(Id),
	OrderLineNr int not null,
	ProductId int not null references Products(Id),
	Quantity int not null

	primary key (OrderId, OrderLineNr)
)