-- Thủ tục lấy giá tiền món ăn - Form Orders
create proc getPriceFood
	@price decimal(10,3) out,
	@FoodID varchar(10)
as
	select @price = price from Foods where foodid = @foodid

declare @price decimal(10,3)
exec getPriceFood @price out , 'f01'
select @price

-- Thủ tục lấy lấy và tách ID từ bảng Bookings để tăng ID - Form Bookings
create proc getIdBooking
	@BookId int out
as
	select @BookId = SUBSTRING(max(bookId), 5, 2) + 1 from bookings

declare @idBooking int
exec getidbooking @idBooking out
select @idBooking


