Create table Design
(

id int primary key identity(1,1),
FirstName nvarchar (300),
Lastname nvarchar (400),
Email nvarchar (400),
PhoneNumber bigint,
message nvarchar(4000)
)

select * from dbo.Design

create procedure SelectDesign
as

begin
select * from dbo.Design

end

exec SelectDesign

create procedure InsertDesign(@FirstName nvarchar(300),@Lastname nvarchar (400),@Email nvarchar(400),@PhoneNumber bigint,@message nvarchar(4000))
as
begin
Insert into dbo.Design (FirstName,Lastname,Email,PhoneNumber,message) values(@FirstName,@Lastname,@Email,@PhoneNumber,@message)
end

exec InsertDesign'sibi','s','sibii@gmail.com',627694465,'Nice'