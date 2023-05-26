select  * from class
create proc sp_inprod1(@pid as int,@pn varchar(20),@page as int,@plocation
varchar(20))
as
begin
insert into class values(@pid,@pn,@page,@plocation);
end

exec sp_inprod1 23,'bluetooth',30,'nagpur'