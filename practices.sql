
create table salesmans1 (salesman_id int primary key, name varchar(20),city varchar(20), 
 commission int)
insert into salesmans1 values(5001,'James Hoog', 'New York', 0.15),
(5002, 'Nail Knite', 'Paris', 0.13),
(5005, 'Pit Alex', 'London', 0.11),
(5006 ,'Mc Lyon', 'Paris' ,0.14),
(5003, 'Lauson Hen', 'San Jose', 0.12),
(5007, 'Paul Adam', 'Rome', 0.13)



create table customer(customer_id int primary key, cust_name varchar(20),city varchar(20),grade int,
salesman_id int constraint f1 foreign key(salesman_id) references salesmans1(salesman_id));
insert into customer values(3002,' Nick Rimando','New York ' ,100 ,5001),
(3007,  'Brad Davis' , 'New York', 200 ,5001),
(3005 ,'Graham Zusi',  'California', 200 , 5002),
(3008 , 'Julian Green' ,'London' , 300 , 5002),
(3004 , 'Fabian Johnson' , 'Paris' ,300 , 5006),
(3009 , 'Geoff Cameron' , 'Berlin' , 100 , 5003),
(3003 ,'Jozy Altidor' ,'Moscow' ,200 ,5007),
(3001 , 'Brad Guzan', 'London', null, 5005)


create table orderr(ord_no int, purch_amt int, ord_date int,customer_id int, salesman_id int ,
constraint ef1 foreign key(salesman_id) references salesmans1(salesman_id),constraint 
ff1 foreign key(customer_id) references customer(customer_id))
insert into orderr values(70001, 150.5 ,2012-10-05, 3005, 5002),
(70009, 270.65 ,2012-09-10, 3001 ,5005),
(70002, 65.26 ,2012-10-05 ,3002, 5001),
(70004, 110.5, 2012-08-17 ,3009 ,5003),
(70007, 948.5 ,2012-09-10 ,3005, 5002),
(70005 ,2400.6 ,2012-07-27 ,3007 ,5001),
(70008 ,5760, 2012-09-10, 3002 ,5001),
(70010 ,1983.43, 2012-10-10, 3004, 5006),
(70003 ,2480.4, 2012-10-10, 3009 ,5003),
(70012, 250.45, 2012-06-27 ,3008 ,5002),
(70011 ,75.29, 2012-08-17, 3003 ,5007),
(70013 ,3045.6 ,2012-04-25, 3002, 5001)


select * from customer
select * from salesmans1
select * from orderr


select  * from orderr where salesman_id=5007

select  * from orderr where salesman_id=(select salesman_id from salesmans1 where name='paul adam')
select * from orderr where salesman_id=5005
select * from orderr where salesman_id=(select salesman_id from salesmans1 where city='london')
select * from orderr where customer_id=3007
select * from orderr where purch_amt>(select avg(purch_amt) from orderr )
select * from orderr where salesman_id=(select salesman_id from salesmans1 where city='New York')
select commission from salesmans1 where city='paris'
---------Write a query to display all the customers whose ID is 2001 below the salesperson ID of Mc Lyon.
select * from customer where customer_id=(select salesman_id-2001 from salesmans1 where name='Mc Lyon');
----From the following tables write a SQL query to count the number of customers with grades above the
---average in New York City. Return grade and count.--------------
select grade from customer where grade in(select avg(grade) from customer where city='New York')
select grade,count(*)from customer group by grade 
having grade>(select avg(grade) from customer where city='New York')

--------From the following tables write SQL query to find the customers who placed orders on 17th August
-------2012. Return ord_no, purch_amt, ord_date, customer_id, salesman_id and cust_name.-----
select * from orderr where salesman_id in(select salesman_id from salesmans1 where ord_no=70009)
select * from orderr where salesman_id in(select salesman_id from salesmans1 where ord_date=1993)
select * from orderr
---From the following tables write a SQL query to find salespeople who had more than one customer.
--Return salesman_id and name.---
select salesman_id,name from salesmans1 where salesman_id=(select customer_id from customer where min