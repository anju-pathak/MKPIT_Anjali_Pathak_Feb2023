create procedure prod1
as
begin
select * from country
end;
exec prod1
-----------------------------------
create procedure prod2
as
begin
select country_name
from country
order by country_name
end;
exec prod2
-----------------------------
alter procedure prod2
as
begin
select country_name from country order by country_name end;
exec prod2
--------------------min----------------------
select * from fee
create proc prod(@minamout as int)
as
begin
select * from fee
where amout >@minamout
order by amout
end;
exec prod  1200
create proc prr(@minrollno as int)
as begin select feeid,amout from fee
where rollno>@minrollno
end;
exec prr 2
---------------------MAX-------------------------
create proc pre(@maxamout int)
as begin select * from fee
where amout<@maxamout
end;
exec pre 4
create proc prre(@maxamout int)
as begin select * from fee
where amout<=@maxamout
end;
exec prre 1200
---------------min and max---------------------
create proc pr3(@minamout int,@maxamout int)
as begin select * from fee 
where amout>@minamout and amout<@maxamout end;
exec pr3 1000,1500
-------------------null------
create proc pr4(@maxamout int null)
as begin select * from fee
where (@maxamout is null or @maxamout=amout) end;
exec pr4 1200
----------
create proc pr5
as
begin
insert into fee values(109,6,14-17-19,9873,2) end;
exec pr5
select * from fee
create proc sp_inprod1(@pid as int,@pn as
varchar(20),
@pr as decimal,@q as int)
as

begin
insert into product values(@pid,@pn,@pr,@q);
end

exec sp_inprod1 23,'bluetooth',300,3
