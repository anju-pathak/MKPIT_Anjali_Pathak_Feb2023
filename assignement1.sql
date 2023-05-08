create table class(rollno int primary key,name varchar(20),email varchar(30),city varchar(20),courseid int)
insert into class values(1,'mona','mona@gmail.com','nagpur',22),(2,'tanu','tanu@gmail.com','kanpur',23)
,(3,'anju','anju@gmail.com','nagpur',22),(4,'yasmin','yasmin@gmail.com','pglpur',22),
(5,'anju','anju@gmail.com','nagpur',22),(6,'anju','yasmin@gmail.com','nagpur',22)
create table fe1(feeid int,rollno int,feedate int,amount int,courseid int,constraint f11 
foreign key(rollno) references class(rollno))
insert into fe1 values(11,1,12,206,22)
insert into fe1 values(12,2,13,700,21)
insert into fe1 values(13,3,14,500,25)
insert into fe1 values(14,4,15,400,27)
select * from class
select * from fe1
select * from class where city='nagpur'
select rollno from class where name='anju'  order by name 
select * from class where name='anju'  order by name 
select amount from fe1 where amount>0 order by feedate