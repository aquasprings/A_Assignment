create proc cancelOrder1349995
            @orderID int
as
begin
	update tblItem_1349995
	set quantityAvailable = quantityAvailable+(SELECT quantity from tblCart_1349995 where orderID=@orderID)
	where itemName = (SELECT itemName from tblCart_1349995 where orderID= @orderID);
	
	delete from tblCart_1349995
	where orderID= @orderID;
end
go
