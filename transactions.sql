create table prod(prdid int identity,name varchar(20),price int,quantity int)
insert into prod values('mouse',123,2)
insert into prod values('wifi',120,3)
insert into prod values('keyboard',100,9)
insert into prod values('laptop',190,8)
select * from prod
begin transaction
insert into prod values('headphone',900,7)
update prod set name='camera' where price=120
commit transaction
select * from prod
----------------------------rollback-------------
begin transaction
insert into prod values('radio',700,1)
delete from prod where name='mouse'
rollback transaction
select * from prod
----------------set implicit ---------
set implicit_transactions on
begin transaction
insert into prod values('phone',70,11)
delete from prod where name='radio'
rollback transaction
select * from prod

