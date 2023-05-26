-------------query to select name-----------
create procedure p2(@pn as varchar(20)) 
as 
begin
select * from trains 
where train_name=@pn 
end;
exec p2 @pn='maharaja express'
exec p2 @pn='Rajdhani Express'
select * from trains
-----------------------------------------
Create proc pr2 (@pn as varchar(20)) 
as
begin 
select * from trains where origin=@pn
end;
exec pr2 @pn='nagpur'
------------------------------------------
create proc pr11(@pname as varchar(20),@pn as int)
as begin select * from trains where destination=@pname and PNR=@pn end;
exec pr11 @pname='bihar', @pn=122345
------min,max,name
create proc pr12(@minpnr int,@maxpnr int,@pn varchar(20))
as begin select * from trains
where pnr>@minpnr and pnr<@maxpnr and train_name=@pn end;
exec pr12 21925,23335,'poorna express'
------------like------
create proc pr13(@pn varchar(20))
as begin select * from trains
where train_name like '%'+ @pn + '%' end;
exec pr13 @pn='ha'
----------------------------------
create proc prr5
as
begin
insert into trains values('rajmahal',21349,129876,12-3-32,'kolkata','bihar',23,'avaiable','general','tatkal') end;
exec prr5
select * from trains
------------------insert with parameters---------
create proc inprod1(@pid as int,@pn as
varchar(20),
@pr as decimal,@q as int)
as
begin
insert into product values(@pid,@pn,@pr,@q);
end

exec sp_inprod1 23,'bluetooth',300,3