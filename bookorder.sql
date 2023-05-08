create table orders(order_no int primary key,order_date varchar(20),order_id int)
create table orderid(order_no int,order_id int,rate int,quantity int,constraint c1 foreign key (order_no) references orders(order_no))
insert into orders values(1,12-2-23,123)
insert into orders values(2,12-1-23,124)
insert into orders values(3,12-2-23,125)
select * from orders
select * from orderid
insert into orderid values(1,123,250,2)
insert into orderid values(1,123,500,1)

insert into orderid values(2,124,200,2)
insert into orderid values(2,124,600,1)
insert into orderid values(3,125,259,1)
