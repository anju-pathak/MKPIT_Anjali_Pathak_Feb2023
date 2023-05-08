-------code for composite key---------------
create table emp(empid int,name varchar(20),psportno int,drivingno int,primary key(psportno,drivingno))
insert into emp values(12,'anjali',23,43)
insert into emp values(12,'anjali',22,43)
select * from emp

create table cust(custid int,custname varchar(20),paid int,mobile varchar(20),primary key(paid,mobile))
insert into cust values(12,'kajak',54,6789098)
insert into cust values(12,'kajak',04,678908)
select * from cust
-------code for composite key---------------

-------code for unique key---------------
create table emp111(empid int primary key,name varchar(20),psportno int,drivingno int constraint eee1 unique(psportno,drivingno))
insert into emp111 values(1,'anjali',22,63)
insert into emp111 values(2,'anjali',20,63)
select * from emp111


create table cust1(custid int primary key,custname varchar(20),moblie varchar(20), unique(moblie))
insert into cust1 values(12,'kajal',8765900)
insert into cust1 values(13,'kajal',8765901)
select * from cust1
-------code for unique key---------------
create table emp12(empid int primary key,name varchar(20),psportno int,drivingno int unique(psportno), unique (drivingno))
insert into emp12 values(12,'anjali',23,33)
insert into emp12 values(16,'anjali',29,30)
select * from emp12
---------------------------------------------
------code for check---------------
create table result(rollno int primary key ,name varchar(20) ,marks int, check(marks>0))
insert into result values (1,'mona',9)
select * from result
---------code for identity------------
create table result1(rollno int identity primary key ,name varchar(20) ,marks int, check(marks>0))
insert into result1 values ('mona',9)
select * from result1
---------code for check-----------
create table prd1(prdid int identity primary key,prdname varchar(20),price int,discount int,check(price>0),check(discount>0)
,check(discount<price))
insert into prd1 values('kajal',50,12)
insert into prd1 values('powder',50,12)
select * from prd1
------------------------------------------------------
-----------------null --------------------
create table prd21(prdid int identity primary key,prdname varchar(20) ,price int null)
insert into prd21 values('kajal',50)
insert into prd21 values('powder',null)
select * from prd1
-----------------null --------------------
create table prd22(prdid int identity primary key,prdname varchar(20),price int,discount int,check(price>0),check(discount>0)
,check(discount<price))
insert into prd22 values(null,50,12)
insert into prd22 values('powder',50,12)
select * from prd22
---------------------------------------check using constraint-----------
create table prd23(prdid int identity primary key,prdname varchar(20),price int,discount int,check(price>0),check(discount>0) ,CONSTRAINT c1
check(discount<price));
insert into prd23 values(null,50,12)
insert into prd23 values('powder',50,12)
select * from prd23
---------------------------------------check using and-----------
create table prd24(prdid int identity primary key,prdname varchar(20),price int,discount int,check(price>0),check(discount>0 and discount<price));
insert into prd24 values(null,50,12)
insert into prd24 values('powder',50,12)
select * from prd24
-----------------------------alter--------------------------------
create table prd25(prdid int identity primary key,prdname varchar(20),price int,discount int,check(price>0),check(discount>0 and discount<price));
insert into prd25 values(null,50,12)
insert into prd25 values('powder',50,12)

alter  table  prd25
add mobileno varchar(20)
insert into prd25 values(43446)
------------------------------------------------------------------------------------------------
create table prd27(prdid int identity primary key,prdname varchar(20),price int,discount int,check(price>0),check(discount>0 and discount<price));
insert into prd27 values(null,50,12)
insert into prd27 values('powder',50,12)
drop table prd27

select * from prd27

----------------- not null --------------------
create table prd26(prdid int identity primary key,prdname varchar(20) ,price int not null)
insert into prd26 values('kajal',50)
insert into prd26 values('powder',76)
select * from prd26
--------------------------drop table--------------------------

create table prd28(prdid int identity primary key,prdname varchar(20) ,price int not null)
insert into prd28 values('kajal',50)
insert into prd28 values('powder',76)
select * from prd28
ALTER TABLE prd28
DROP COLUMN prdname;