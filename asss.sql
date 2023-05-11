create table salesmans(salesman_id int primary key, name varchar(20),city varchar(20),commission int)
insert into salesmans values(5001,' James Hoog', ' New York' , 15)
insert into salesmans values(5002,'Nail Knite ','Paris' ,13)
insert into salesmans values(5005 ,' Pit Alex ',' London' ,11)
insert into salesmans values(5006 ,' Mc Lyon' ,' Paris', 14)
insert into salesmans values(5007 ,' Paul Adam', 'Rome' , 13)
insert into salesmans values(5003 ,' Lauson Hen', ' San Jose' ,12)
select * from salesmans
select name ,commission from salesmans

create table orders1(ordno int primary key, purchamt int, orddate int, customerid int, salesman_id int
 constraint ss1 foreign key (salesman_id) references salesmans(salesman_id));
 insert into orders1 values(70001 ,150, 2012/10/05, 3005 ,5002),
(70009 ,270, 2012-09-10, 3001 ,5005),
(70002, 65,2012-10-05 ,3002, 5001),
(70004, 110, 2012-08-17, 3009, 5003),
(70007 ,948, 2012-09-10 ,3005, 5002),
(70005 ,2400, 2012-07-27 ,3007, 5001),
(70008 ,5760 ,2012-09-10, 3002, 50010)