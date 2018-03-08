create proc itemDetails1349995
	@itemName varchar(50),
	@quantity int OUTPUT,
	@itemPrice float OUTPUT
as
begin
	SELECT @quantity=quantityAvailable from tblItem_1349995 where itemName = @itemName;
	SELECT @itemPrice=price from tblItem_1349995 where itemName=@itemName;
end
go
