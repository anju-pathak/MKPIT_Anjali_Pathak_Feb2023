create table school(rollno int primary key,name varchar(20),city varchar(20),courseid int)
insert into school values(1,'anjali','nagpur',1),(2,'mona','kalmeshwar',1),(3,'karishma','burdi',2),
(4,'tanu','sadar',3),(5,'yasmin','nagpur',2)
create table fee(feeid int primary key,rollno int,feesdate int,amout int,courseid int,constraint c21 foreign key
(rollno) references school(rollno));
insert into fee values(101,1,12-12-12,1200,1),(102,2,13-12-12,1000,1),(103,3,16-12-12,1400,2),
(104,4,19-12-12,1400,3),(105,5,12-12-12,1900,2)

select * from school where rollno in(select rollno from fee where name='mona');
select city,name from school where city in(select city from fee where city='nagpur');
select city from school where city in(select city from fee where city='nagpur');
select city,name,rollno from school where city in(select city from fee where city='kalmeshwar');
select feeid,amout from fee where rollno in(select rollno from fee where amout>=100);
select * from school where courseid in(select courseid from school where courseid=1);
select feeid,amout,name from fee where rollno in(select rollno from school where city='nagpur');