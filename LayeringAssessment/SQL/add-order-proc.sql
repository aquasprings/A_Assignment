create proc addOrder1349995
			@itemName varchar(50),
            @quantity int,
			@totalPrice float,
            @name varchar(50),
            @contact varchar(50),
            @email varchar(50),
            @orderID int OUTPUT
as
begin
	insert into tblCart_1349995
	(itemName,quantity,totalPrice,customerName,customerContact,customerEmail) 
	values (@itemName, @quantity,@totalPrice , @name, @contact , @email);

	SET @orderID=@@IDENTITY;
end
go
