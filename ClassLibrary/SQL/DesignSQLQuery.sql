create table DesignPage
( id int primary key identity (1,1),
FullName nvarchar(100),
Email_address nvarchar(200),
comments nvarchar(1000)

)
select * from dbo.DesignPage


create procedure SelectDesignpage
as

begin
select * from dbo.DesignPage

end

exec SelectDesignpage

create procedure InsertDesignpage(@FullName nvarchar(100),@Email_address nvarchar(200),@comments nvarchar(1000))
as
begin
Insert into dbo.DesignPage (FullName,Email_address,comments) values(@FullName,@Email_address,@comments)
end

exec InsertDesignpage'Hari','hari@gmail.com','Okay'