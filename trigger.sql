create table e1(empid int,ename varchar(20))
insert into e1 values(1,'amit'),(2,'amita');
create table emplog(EMPID INT NOT NULL,LOGID INT identity,operation varchar(20) not null
,updatedate datetime not null)
create  trigger emp
on e1
for insert 
as
insert into emplog(EMPID,operation,updatedate)
select empid,'insert',getdate() from inserted
insert into e1 values(1,'amit'),(2,'amita');
select * from e1
select * from emplog
------------------delete- for trigger---------------------
create trigger empp
on e1
 after update as
insert into emplog(EMPID,operation,updatedate)
select empid,'insert',GETDATE() from deleted
select * from e1
update e1 set ename='amitaana'
where empid=2
-------------------------------------------