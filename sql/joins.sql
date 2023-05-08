-------------------joins--------------------------------
------------------- inner join--------------------------------
create table std(id int identity primary key,name varchar(20),addmission_no int,age int)
insert into std values('anjali',11,12),('mona',12,12),('tannu',13,14),('karishma',14,15)
,('yasmin',15,17)

--------------------------creating another table------------------
create table fee(name varchar(20),addmission_no int,course varchar(20))
insert into fee values('kajal',11,'java'),('sana',12,'c'),('jaanu',13,'java')

select std.id,std.name,std.addmission_no,fee.name,fee.addmission_no
from std inner join fee on std.addmission_no=fee.addmission_no;

select std.id,std.name,fee.name,fee.course from std inner join fee on std.name=fee.name;
------------------- cross join--------------------------------
select std.id,std.name,std.addmission_no,fee.name,fee.addmission_no
from std cross join fee where std.addmission_no=fee.addmission_no;

------------------- left join--------------------------------
--select std.id,std.name,std.addmission_no,fee.name,fee.addmission_no,fee.course
--from std left join fee on std.addmission_no=fee.addmission_no;

select std.name,std.addmission_no,fee.addmission_no
from std left join fee on std.addmission_no=fee.addmission_no;

-------------------right join--------------------------------
select std.id,std.name,std.addmission_no,fee.name,fee.addmission_no
from std right join fee on std.addmission_no=fee.addmission_no;

--------------------full join-----------------------------------
select std.id,std.addmission_no,fee.name,fee.addmission_no from std full join fee 
on std.addmission_no=fee.addmission_no;

------------------------------------------------default constraint-------------
create table gee(name varchar(20) not null,id int identity primary key ,mobile varchar(20),city varchar(20)default'nagpur');
insert into gee values('laptop',9421776551,'nodia')
select * from gee 
------------------------------------------------default constraint-------------
create table std1(name varchar(20) ,id int ,mobile varchar(20),city varchar(20)DEFAULT'nagpur');
insert into std1 values('laptop',1,9421776551,DEFAULT)
select * from std1
---------------------------------------------DROP default constraint-------------
create table class(id int,age int constraint df default 10)
insert into class values(1,default)
select * from class

alter table class 
drop constraint df
insert into class values(2,default)
select * from class



