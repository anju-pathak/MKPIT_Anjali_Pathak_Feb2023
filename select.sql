create table cakelinkss(storeid int primary key,storename varchar(20),phone int,email varchar(20),street varchar(20),city varchar(20),state varchar(20),zipcode int)
--code for store--
insert into cakelinkss values(11,'cakelink',94217551,'anjalipathakgmail','kalmeshwar','nagpur','maharashtra',441501)

---creating category---
create table categorys(categoryid int primary key,categoryname varchar(20))
insert into categorys values(12,'chocolate')
---creating brand-----
create table brandss(brandid int primary key,brandname varchar(20))
insert into brandss values(13,'darkchocolate')
----creating product---
create table products(productid int primary key,name varchar(20),brandid int,categoryid int,model_year int,listprice int,constraint bb1 foreign key
(brandid) references brandss(brandid),constraint cc1 foreign key (categoryid) references categorys(categoryid))
insert into products values(14,'cake',13,12,1995,200)
----creating stock---
create table stocks(storeid int,productid int,quanity int,constraint s1 foreign key
(storeid)references cakelinkss(storeid),constraint p1 foreign key(productid) references products(productid))
insert into stock values(11,14,1)
-----creating customer----
create table customers(customerid int primary key,firstname varchar(20), lastname varchar(20),phone int,email varchar(30),street varchar(20),city varchar(20),state varchar(20),zipcode int)
insert into customers values(15,'anjali','pathak',8668470,'anjalipathakgmailcom','policeline','nagpur','maharashtra',400871)
-------creating staff---
create table staffs(staffid int primary key,firstname varchar(20), lastname varchar(20),phone int,email varchar(30),active varchar(20),managerid int,storeid int,constraint
s1 foreign key(storeid) references cakelinkss(storeid))
insert into staffs values(16,'monali','sharma',874448,'monadargamil','yes',17,11)
-------creating order-------
create table orderss(orderid int primary key,customerid int,orderstatus varchar(20),orderdate int,requireddate int,shippeddate int,storeid int,staffid int, constraint
cuu1 foreign key(customerid) references customerss(customerid),constraint ssss1 foreign key(storeid) references cakelink(storeid),constraint
saa1 foreign key(staffid) references staff(staffid))
insert into ordersss values(19,15,'ready',12-3-23,13-3-23,13-3-23,11,16)
-------creating orderitems---------
create table oderitems(orderid int,itemid int,productid int,quantity int,listprice int,discount int,constraint qO1 foreign key(orderid)references ordersss(orderid))

insert into oderitemss values(19,20,14,1,200,2)
select * from oderitemss
select * from ordersss
select *from products
select * from customerss
select * from oderitemss
select * from cakelinkss


----------select statement---------
select * from cakelinkss
-----------delete--
delete cakelinks
select * from cakelinks

select storeid from cakelink

