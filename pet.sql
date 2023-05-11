create table pet(petid int primary key,name varchar(20),score int)
insert into pet values(1,'dog',100),(2,'cat',200),(3,'donkey',300),(4,'goat',150)
select petid,name,score from pet where score=(select max(score) from pet);
select petid,name,score from pet where score=(select min(score) from pet);
select sum(score) from pet;
select avg(score) from pet
sp_rename 'pet','newpet';
sp_help 'newpet';
