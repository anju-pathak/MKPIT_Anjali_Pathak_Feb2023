create table course(courseid int primary key,coursename varchar(20),fees int)
insert into course values(1,'java',2000)
insert into course values(2,'c',1000)
insert into course values(3,'c++',15000)
insert into course values(4,'dotnet',22000)
insert into course values(5,'csharp',21000)

create table country(countryid int primary key,countryname varchar(20))
insert into country values(1001,'India');
insert into country values(1002,'USA');
insert into country values(1003,'China');



create table state(stateid int primary key,statename varchar(20),countryid int, constraint c11 foreign key(countryid) 
references country(countryid))
insert into state values(101,'Maharashtra',1001);
insert into state values(102,'Bihar',1001);
insert into state values(103,'Texas',1002);
insert into state values(104,'ohio',1002);
insert into state values(105,'fujin',1003);
insert into state values(106,'yunnan',1003);

create table citys(cityid int primary key,cityname varchar(20),stateid int ,constraint c2 foreign key(stateid)
references state(stateid));
insert into citys values(11,'mumbai',101)
insert into citys values(12,'nagpur',101)
insert into citys values(13,'patna',102)
insert into citys values(14,'buxar',102)
insert into citys values(15,'Houston',103)
insert into citys values(16,'Boston',103)
insert into citys values(17,'san rancisco',104)
insert into citys values(18,'newyork',104)
insert into citys values(19,'Shanghai',105)
insert into citys values(20,'Tianjin',105)
insert into citys values(21,'Chuzhou',106)
insert into citys values(22,'macau',106)

create table addre(courseid int primary key identity,fees int,countryid int ,constraint d31
foreign key(countryid) references country(countryid),
stateid int constraint d41 foreign key(stateid) references state(stateid) ,cityid int constraint d51
foreign key(cityid) references citys(cityid),Name varchar(20),Date datetime,AmountPaid int,Balance int)
select * from country;
select * from state
select * from citys
select * from addre

select  s.statename from state s inner join country c on
s.countryid=c.countryid where countryname='india';
select  s.cityname from citys s inner join state c on
s.stateid=c.stateid where statename='Bihar';
select coursename from course
select fees from course


create table address1(name varchar(20),gender varchar(20),contact int,country varchar(20),state varchar(20),city varchar(20),
date varchar(20),cource varchar(20),fee int,amountpaid int,balance int)