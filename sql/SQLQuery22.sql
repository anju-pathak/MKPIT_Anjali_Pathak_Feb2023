create table prd(prdid int,prdname varchar(20),region varchar(20),year varchar(20),
quantity int,price int)
insert into prd values(1,'keyboard','east',2012,4,400)
insert into prd values(2,'mouse','south',2013,5,200)
insert into prd values(3,'keyboard','west',2012,3,300)
insert into prd values(4,'speaker','north',2015,9,400)
insert into prd values(5,'cd','east',2015,3,600)
insert into prd values(6,'mouse','west',2012,1,900)
select * from prd
select min(quantity)as prdname from prd where quantity>2
select max(quantity)as prdname from prd 
select min(price) as price from prd
select max(price)as price from prd
select prdname ,max(price) as price from prd  where (price>100) group by prdname
select prdname,min(price) as price from prd where(price>200) group by prdname
select prdname,min(distinct price) from prd where (price>500) group by prdname
select prd, max(quantity) as "quantity" from quantity group by prd order by prd
SELECT AVG( DISTINCT price)    
    FROM prd  
    WHERE price>0;

