create table tblCart_1349995
(
	orderID int IDENTITY(1,1) PRIMARY KEY,
	itemName varchar(50) NOT NULL,
	quantity int NOT NULL,
	totalPrice int  NOT NULL,
	customerName varchar(50) NOT NULL,
	customerContact varchar(50) NOT NULL,
	customerEmail varchar(50) NOT NULL
);
create table  tblItem_1349995
(
	itemID int IDENTITY(101,1) PRIMARY KEY,
	itemName varchar(50) NOT NULL,
	price float NOT NULL,
	manufacturingDate datetime NOT NULL,
	quantityAvailable int NOT NULL 
);
