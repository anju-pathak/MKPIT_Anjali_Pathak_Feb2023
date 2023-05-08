create table details(courseid int primary key,coursename varchar(20))
insert into details values(1,'Dotnet'),(2,'java')
create table course(rollno int primary key,name varchar(20),courseid int,constraint cc1 foreign key(courseid)
references details(courseid))
insert into course values(1,'amit',1),(2,'yasmin',2),(3,'mona',1),(4,'tanu',2)
select * from course
---------------inner join-------------
select d.courseid,c.rollno,c.name from details d inner join course c
on d.courseid=c.courseid

select d.courseid,coursename,c.name,c.rollno from 
details d inner join course c on d.courseid=c.courseid
-----------------left join--------------------
select d.courseid,d.courseid,c.name from details d left join course c
on d.courseid=c.courseid

------------------------------subquery---------------------------------------
select name from course where courseid IN(select courseid from details where name ='yasmin');
--------------------------------------------------------------


