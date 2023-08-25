create table Product
(
productId int primary key identity(1,1),
ProductName nvarchar(200),
ProductType nvarchar(200),
Quantity int,
Price int,
ProductCode nvarchar(100)  unique not null
)

select * from dbo.Product

exec dbo.GetProductType

create procedure Getproduct
as

begin
select * from dbo.Product

end

exec dbo.Getproduct


create or alter procedure InsertProduct(@ProductName nvarchar(200),@productType nvarchar(200),@Quantity int,@Price int,@ProductCode  nvarchar(100))
as
begin
insert into dbo.Product (ProductName,ProductType,Quantity,Price,ProductCode) values(@ProductName,@productType,@Quantity,@Price,@ProductCode)
end

exec InsertProduct 'jam','snacks',10,14,'f1'


Create or alter procedure UpdateProduct(@productId int,@ProductName nvarchar(200),@productType nvarchar(200),@Quantity int,@Price int,@ProductCode  nvarchar(100))
as
begin
update dbo.Product set ProductName=@ProductName,ProductType=@productType,Quantity=@Quantity,price=@Price,ProductCode=@ProductCode where productId=@productId
end

exec dbo.UpdateProduct 1,'Sinthol','soap',2,70,'Si1'

Create or alter procedure DeleteProduct(@productId int)

as
begin
Delete from dbo.Product where productId=@productId
end

exec dbo.DeleteProduct  5
-------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------

Create table ProductDropDown
(
ProductTypeId int primary key identity(1,1),
ProductType nvarchar (200)
)

select * from dbo.ProductDropDown

Create or alter procedure GetProductType
as
begin
select * from dbo.ProductDropDown

end

exec dbo.GetProductType

Create or alter procedure InsertProductType(@ProductType NVARCHAR (300))
AS
BEGIN
insert into dbo.ProductDropDown (ProductType) values (@ProductType )
END

exec dbo.InsertProductType 'water'

Create or alter procedure UpdateProductType(@ProductTypeId INT,@ProductType nvarchar (200))
as
begin
Update dbo.ProductDropDown set ProductType =@ProductType where ProductTypeId=@ProductTypeId
end

exec dbo.UpdateProductType 2,'IceCreams'

Create or alter procedure DeleteProductType(@ProductTypeId int)
as
begin
Delete from dbo.ProductDropDown where ProductTypeId=@ProductTypeId
end

exec dbo.DeleteProductType 1

create or alter procedure GetproductTypeById(@productTypeid int)
as

begin
select * from dbo.Product where productTypeid=@productTypeid
end

exec dbo.GetproductById 6


select p.ProductName,p.ProductCode,d.ProductType from dbo.Product p inner join dbo.ProductDropDown d on p.productId=d.ProductTypeId

