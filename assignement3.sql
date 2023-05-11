create table teacher(id int identity,name varchar(20))
insert into teacher values('anjali'),('mona')
delete teacher
insert into teacher values('anjali'),('mona')
truncate table teacher
insert into teacher values('anjali'),('mona')
select * from teacher
alter table teacher
add rollno int;
update  teacher set rollno=1
where name='anjali';
select * from teacher
alter table teacher
drop column rollno;
select * from teacher
EXEC sp_rename 'teacher.name',
'stuname','COLUMN'

