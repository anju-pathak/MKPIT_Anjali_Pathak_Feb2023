create table persons(id int,name varchar(20))
insert into persons values(1,'anjali'),(2,'mona')
-------------delete--------
delete  persons
select * from persons
-----------------truncate--------------------
create table person(id int identity,name varchar(20))
insert into person values('anjali'),('mona')
select * from person
delete  person
truncate table person
------------update---------
update  persons set id=3
where name='anjali';
update persons set name='tanu' where name='anjali';
select * from persons
--------------drop--------
alter table persons
drop column name;
select * from persons
---------------rename----------------
sp_rename 'persons' , 'personsnew';
select * from personsnew
-----------adding 1 new column------
alter table person
add  price int;
-------------query to add value in newly created column---------

update person set price=200
where id=3;
update person set price=200.98
where id=4 and name='mona';
select * from person
--------to change datatype--
alter table person
alter column price dec(10,2)
select * from person
