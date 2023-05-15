select * from sys.server_principals

DECLARE @sys_usr CHAR(30);
SET @sys_usr = SYSTEM_user;
SELECT 'The current system user is: '+ @sys_usr;

SELECT local_tcp_port FROM sys.dm_exec_connections WHERE session_id = @@SPID

select * from orders

DECLARE @VALUE INT  
SELECT @VALUE = SUBSTRING(MAX(ORDERID), 3, 2) + 1 FROM ORDERS
SELECT @VALUE

declare @price decimal(10,2)
select @price = price from dishs where dishid = 'dish10'
select @price

declare @quantity int
select @quantity = quantity from orders where dishid = 'dish10'
select @quantity

create proc getTotalPrice
	@price decimal(10,2) out, @quantity int out, @dishId varchar(10)
as
	begin 
		select @price = price from dishs where dishid = @dishId
		select @quantity = quantity from orders where dishid = @dishId
	end

declare @price decimal(10,2), @quantity int
exec getTotalPrice @price out, @quantity out, 'dish2'
select @price, @quantity

SELECT name, password_hash FROM sys.sql_logins WHERE name = 'manhkhanh';
SELECT name, password_hash FROM sys.sql_logins WHERE name = 'manhkhanh' AND PWDCOMPARE('1234', password_hash) = 1;

select * from Customers

SELECT CustomerName from (orders join Booking on Orders.BookID = Booking.BookID) join Customers on Customers.CustomerID = Booking.CustomerID
group by CustomerName


declare @id int
select @id = substring(max(billid),2,2) + 1 from bills
select @id

declare @tableNumber int
SELECT @tableNumber = TableID from orders join Booking on Orders.BookID = Booking.BookID
where OrderID = 'od2'
group by TableID
select @tablenumber

select * from Customers

select * from Bookings

select * from Orders

select * from  Bills

select* from Tables

SELECT CustomerName from (orders join Booking on Orders.BookID = Booking.BookID) join Customers on Customers.CustomerID = Booking.CustomerID
where Orders.OrderID = 'OD1'
group by CustomerName

SELECT Orders.BookID from (orders join Booking on Orders.BookID = Booking.BookID) join Dishs on Dishs.DishID = Orders.DishID
where Orders.OrderID = 'od1'
group by Orders.BookID

declare @bookid decimal(10,2)
SELECT  
from Orders 
where Orders.orderid = 'od1'
select @bookid

DECLARE @Prices VARCHAR(MAX)
SELECT @Prices = COALESCE(@Prices + ',', '') + CONVERT(VARCHAR, price)
FROM orders
where Orders.BookID = 'book1'
select @PricesArray

DECLARE @PriceArray XML
SET @PriceArray = '<Prices><Price>' + REPLACE(@Prices, ',', '</Price><Price>') + '</Price></Prices>'

UPDATE orders
SET price_array = @PriceArray


select * from Staffs

SELECT Orders.OrderID, NameDish, Quantity, orders.Price 
from(orders join Booking on Orders.BookID = Booking.BookID) join Dishs on Dishs.DishID = Orders.DishID 
where Orders.BookID = 'book3'
group by Orders.OrderID, NameDish, Quantity, orders.Price

select * from customers
delete Orders


SELECT name
FROM sys.procedures

drop proc getPriceDish



select * from Bookings



select Orders.OrderID, Orders.StaffID, Orders.BookID, FoodID, Quantity, Price from orders

INSERT INTO orders VALUES 
('OD01', 'NV01', 'book2', 'f02', 2, 200.000)

SELECT * FROM ORDERS join Bookings on Orders.BookID = Bookings.BookID WHERE Orders.BookID = 'book2'

select * from Orders

DELETE FROM ORDERS WHERE BookID 

SELECT *, pay from (Orders join Bookings on Orders.BookID = Bookings.BookID)
join Customers on Customers.CustomerID = Bookings.CustomerID
group by Pay

select  Pay from Orders join Bookings on Orders.BookID = Bookings.BookID

DELETE FROM Bookings WHERE BOOKID = 'book1'

SELECT Orders.OrderID, Orders.StaffID, Orders.BookID, FoodID, Quantity, Price 
FROM ORDERS join Bookings on Orders.BookID = Bookings.BookID 
WHERE Orders.BookID = 'book1' and Pay NOT IN ('Đã thanh toán', 'Hủy đặt bàn')

select * from Bookings 
WHERE Pay NOT IN (N'Đã thanh toán', N'Hủy đăng ký')


SELECT STATUS FROM VIEWTABLES 
GROUP BY STATUS

SELECT CustomerName from(orders join Bookings on Orders.BookID = Bookings.BookID)
join Customers on Customers.CustomerID = Bookings.CustomerID 
Where  Pay = N'chưa thanh toán' 
group by CustomerName

UPDATE ORDERS SET
STAFFID = '{staffId}', 
BOOKID = '{bookId}', 
FOODID = '{FoodId}',
QUANTITY = 4, 
PRICE = 124 ,
WHERE ORDERID = '{id}'

"DECLARE @VALUE INT " +
"SELECT @VALUE = SUBSTRING(MAX(ORDERID), 3, 2) + 1 FROM ORDERS " +
"SELECT @VALUE";

"declare @price decimal(10, 3) " +
                    $"exec getPriceFood @price out, {FoodID} " +
                    "select @price";

$"declare @table int = {tableID}; " +
                "if exists (select * from tables where @table = tableid and Status = 'off') " +
                    "select 1; " +
                "else " +
                    "select 0";
"declare @idBooking int;\n" +
                        "exec getIdBooking @idBooking out;\n" +
                        "select @idBooking";

"DECLARE @Prices VARCHAR(MAX) " +
                    "SELECT @Prices = COALESCE(@Prices + ',', '') + CONVERT(VARCHAR, price) " +
                    "FROM Orders " +
                    $"Where Orders.BookID = '{getBookID(orderId)}' " +
                    "Select @Prices";

"declare @bookid varchar(10) "+
                "SELECT @bookid = BookID " +
                    "from Orders " +
                    $"where Orders.OrderID = '{orderId}' " +
                    "group by BookId " +
                    "select @bookid";

 "declare @tableNumber int " +
                    "SELECT TableID from orders join Bookings on Orders.BookID = Bookings.BookID " +
                    $"Where OrderID = '{this.orderID}' " +
                    "group by TableID " +
                    "select @tablenumber";

declare @id varchar(10) " +
                "SELECT @id = Orders.OrderID from(orders join Bookings on Orders.BookID = Bookings.BookID)" +
                "join Customers on Customers.CustomerID = Bookings.CustomerID " +
                $"Where Customers.CustomerName = N'{cbCustomerName.Text}' " +
                "group by Orders.OrderID " +
                "select @id";

"declare @id int " +
                "select @id = max(billid) + 1 from Bills " +
                "select @id";

 "DECLARE @VALUE INT " +
                "SELECT @VALUE = MAX(TABLEID) + 1 FROM TABLES " +
                "SELECT @VALUE


ALTER FUNCTION dbo.queryFunc(@TableName varchar(20), @select nvarchar(50),
@from nvarchar(100), @where nvarchar(100), @groupBy nvarchar(50))
RETURNS TABLE
AS 
	RETURN (
		SELECT @ID = CASE 
			WHEN LEN(@WHERE) = 0 AND LEN(@GROUPBY) = 0
				THEN @SELECT + 1 
				FROM @FROM
			WHEN LEN(@WHERE) > 0 AND LEN(@GROUPBY) = 0
				THEN @SELECT + 1
				FROM @FROM 
				WHERE @WHERE
			WHEN LEN(@WHERE) > 0 AND LEN(@GROUPBY) > 0
				THEN @SELECT + 1
				FROM @FROM 
				WHERE @WHERE 
				GROUP BY @GROUPBY
		END AS ID
	)

ALTER FUNCTION dbo.queryFunc(@TableName varchar(20), @select nvarchar(50),
@from nvarchar(100), @where nvarchar(100), @groupBy nvarchar(50))
RETURNS TABLE
AS 
BEGIN
	DECLARE @ID INT
	RETURN (
		SELECT @ID = CASE 
			WHEN LEN(@WHERE) = 0 AND LEN(@GROUPBY) = 0
				THEN @SELECT + 1 
			WHEN LEN(@WHERE) > 0 AND LEN(@GROUPBY) = 0
				THEN @SELECT + 1
				FROM @FROM 
				WHERE @WHERE
			WHEN LEN(@WHERE) > 0 AND LEN(@GROUPBY) > 0
				THEN @SELECT + 1
				FROM @FROM 
				WHERE @WHERE 
				GROUP BY @GROUPBY
			ELSE NULL
		FROM @FROM
	)
END

	CREATE OR ALTER FUNCTION dbo.queryFunc
(
    @TableName varchar(20),
    @select nvarchar(50),
    @from nvarchar(100),
    @where nvarchar(100),
    @groupBy nvarchar(50)
)
RETURNS TABLE
AS RETURN
(
    SELECT 
        CASE 
            WHEN (LEN(@WHERE) = 0 AND LEN(@GROUPBY) = 0) THEN @SELECT + 1 
            WHEN (LEN(@WHERE) > 0 AND LEN(@GROUPBY) = 0) THEN @SELECT + 1 FROM @FROM WHERE @WHERE
            WHEN (LEN(@WHERE) > 0 AND LEN(@GROUPBY) > 0) THEN @SELECT + 1 FROM @FROM WHERE @WHERE GROUP BY @GROUPBY
        END AS ID
)



-- ngonnnn chạy tốt test phần khai báo và gán @sql 
-- tí làm phần return và chuyển @sql sang lệnh sql "select * from where group by ..."
create proc queryProcedure
@TableName varchar(max), @select nvarchar(max)
, @where nvarchar(max), @groupBy nvarchar(max)

AS 
BEGIN
	DECLARE @sql nvarchar(max)
	
	DECLARE @ResultTable TABLE (VALUE_PROC nvarchar(max))
	SET @sql = N'SELECT  ' + @select + ' FROM ' + @tableName 
	IF LEN(@where) > 0 
		SET @sql += N' WHERE ' + @where
	ELSE IF  LEN(@groupBy) > 0
		SET @sql +=  N' GROUP BY ' + @groupBy
	IF LEN(@groupBy) > 0 AND LEN(@where) > 0
		SET @sql +=  N' GROUP BY ' + @groupBy
	PRINT @SQL
	INSERT INTO @ResultTable
	EXECUTE sp_executesql @sql
	declare @VALUE nvarchar(max)
	SELECT @VALUE = VALUE_PROC FROM @ResultTable
	IF @VALUE is null 
	begin
		delete from @ResultTable
		insert into @ResultTable(VALUE_PROC) values (1)
	end
	SELECT VALUE_PROC FROM @ResultTable
end

drop proc queryprocedure
select * from bills
exec queryprocedure 'bookings',"SUBSTRING(MAX(BOOKID), 5, 2) + 1"," ", ''
-- về làm thêm bắt lỗi nếu id = 0

delete from bookings
SELECT * FROM (Orders join Bookings on Orders.BookID = Bookings.BookID)
                join Customers on Customers.CustomerID = Bookings.CustomerID  where FOODID = 'f06'

SELECT  Orders.OrderID, Customers.CustomerName  FROM (Orders join Bookings on Orders.BookID = Bookings.BookID) 
join Customers on Customers.CustomerID = Bookings.CustomerID WHERE Customers.CustomerName = N'Ngân Nguyễn' GROUP BY Orders.OrderID, Customers.CustomerName


DECLARE @sql nvarchar(max), @TableName varchar(max) = 'Orders', @select nvarchar(max) 'STRING_AGG(CONVERT(VARCHAR, price), ',') '
, @where nvarchar(max), @groupBy nvarchar(max)
	
	DECLARE @ResultTable TABLE (VALUE_PROC nvarchar(max))
	SET @sql = N'SELECT  ' + @select + ' FROM ' + @tableName 
	IF LEN(@where) > 0 
		SET @sql += N' WHERE ' + @where
	ELSE IF  LEN(@groupBy) > 0
		SET @sql +=  N' GROUP BY ' + @groupBy
	IF LEN(@groupBy) > 0 AND LEN(@where) > 0
		SET @sql +=  N' GROUP BY ' + @groupBy
	PRINT @SQL

select * from customers

DELETE FROM BILLS

select ORDERID, ORDERS.STAFFID, ORDERS.BOOKID, FOODID, QUANTITY, PRICE, PAY from
ORDERS JOIN BOOKINGS ON ORDERS.BOOKID = BOOKINGS.BOOKID
where ORDERS.BOOKID = 'book04'

select ORDERS.ORDERID, CUSTOMERNAME
from (ORDERS JOIN BOOKINGS ON ORDERS.BOOKID = BOOKINGS.BOOKID) 
JOIN CUSTOMERS ON CUSTOMERS.CUSTOMERID = BOOKINGS.CUSTOMERID 
where CUSTOMERS.CUSTOMERNAME= N'Ngân Nguyễn' and Pay = N'Chưa thanh toán'
group by ORDERS.ORDERID, CUSTOMERNAME

select count(customerid) from bills where customerid = 'KH01'
