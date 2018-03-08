create proc viewAllOrders1349995
as
begin
	SELECT orderID,a.itemName,quantity,totalPrice,customerName,customerContact,customerEmail, manufacturingDate
	FROM (tblCart_1349995 a JOIN tblItem_1349995 b on a.itemName=b.itemName);
end
go
