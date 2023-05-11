create table salesmans(salesman_id int primary key, name varchar(20),city varchar(20),commission int)
insert into salesmans values(5001,' James Hoog', ' New York' , 15)
insert into salesmans values(5002,'Nail Knite ','Paris' ,13)
insert into salesmans values(5005 ,' Pit Alex ',' London' ,11)
insert into salesmans values(5006 ,' Mc Lyon' ,' Paris', 14)
insert into salesmans values(5007 ,' Paul Adam', 'Rome' , 13)
insert into salesmans values(5003 ,' Lauson Hen', ' San Jose' ,12)
select * from salesmans
select name ,commission from salesmans

create table orders(ordno int primary key, purchamt int, orddate int, customerid int, salesman_id int,
 constraint s1 foreign key (salesman_id) references salesmans(salesman_id));
 insert into orders values(70001 ,150, 2012/10/05, 3005 ,5001),
(70009 ,270, 2012-09-10, 3001 ,5002),
(70002, 65,2012-10-05 ,3002, 5005),
(70004, 110, 2012-08-17, 3009, 5006),
(70007 ,948, 2012-09-10 ,3005, 5007),
(70005 ,2400, 2012-07-27 ,3007, 5001),
(70008 ,5760 ,2012-09-10, 3002, 5003)
select orddate, salesman_id, ordno,  purchamt from orders
select city,name from salesmans where city='Paris' 

----------------------------3 table--------------------------
create table order1(ordno int primary key, purchamt int, orddate int,
customer_id int, salesman_id int, constsalesman_id));
insert into order1 values(70001, 150, 2012-10-05, 3005 ,5002),
(70009, 270, 2012-09-10, 3001, 5005),
(70002 ,65, 2012-10-05 ,3002 ,5001),
(70004 ,110,2012-08-17 ,3009, 5003),
(70007, 948, 2012-09-10 ,3005, 5002),
(70005, 2400, 2012-07-27, 3007, 5001),
(70008, 5760, 2012-09-10 ,3002, 5001)
---------- ---------- ---------- ----------- -----------


create table grade(customer_id int, custname varchar, city varchar(20), grade int, salesman_id int,
constraint cc1 foreign key(salesman_id) references salesmans(salesman_id))
insert into grade values(3002,' Nick Rimando', ' New York' , 100 ,5001),
                        (3007 , 'Brad Davis' , 'New York' ,200 , 5001),
                        (3005 , 'Graham Zusi','California ', 200 ,5002),
                        (3008 , 'Julian Green' , 'London ', 300 , 5002),
                         (3004  ,'Fabian Johnson', 'Paris',  300 , 5006),
                          (3009  ,'Geoff Cameron' ,' Berlin',  100 ,5003),
                            (3003  ,'Jozy Altidor' , 'Moscow' , 200 ,5007)