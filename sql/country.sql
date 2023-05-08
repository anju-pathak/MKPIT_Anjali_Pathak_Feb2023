create table country(country_id int identity primary key,country_name varchar(20));
insert into country values('India'),('USA')
create table states(state_id int primary key,state_name varchar(20),country_id int, constraint c11 foreign key(country_id) references
country(country_id));
insert into states values(11,'maharashtra',1)
insert into states values(12,'mp',1)
insert into states values(13,'washington DC',2)
insert into states values(14,'Taxas',2)
Select  * from states
create table city(city_id int primary key,city_name varchar(20),state_id int,constraint c12 foreign key(state_id) 
references states(state_id));
insert into city values(1,'mumabi',11),(2,'nagpur',11)
insert into city values(3,'bhopal',12),(4,'indore',12)
insert into city values(5,'algona',13),(6,'anerdeen',13)
insert into city values(7,'	Houston',14),(8,'Dallas',14)
Select  * from country
Select  * from states
select * from city
select c1.country_id,c1.country_name,s1.state_name from country c1 inner join states s1 on 
c1.country_id=s1.country_id where c1.country_name='India';

select ct.city_name 
from city ct inner join states s1
on ct.state_id=s1.state_id
where s1.state_name='maharashtra'

select state_name from states
where country_id=1
(select country_id from country
where country_name='india');

select state_name from states where country_id=(select country_id from country where country_name='india');
select city_name from city where state_id=(select state_id from states where state_name='mumabi');

