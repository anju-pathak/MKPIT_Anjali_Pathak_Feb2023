create table Studentsss(rollno int,name varchar(20), city varchar(20), state varchar(20),course varchar(20))
insert into Studentsss values(1,'anjali','nagpur','maharashtra','java')
insert into Studentsss values(2,'anjali','pune','maharashtra','java')
insert into Studentsss values(3,'mona','kolkata','WB','c')
insert into Studentsss values(4,'tanu','kalmeshwar','maharashtra','java')
insert into Studentsss values(5,'yasmin','nagpur','maharashtra','c')
insert into Studentsss values(6,'karishma','nagpur','maharashtra','c')
insert into Studentsss values(7,'sana','kanpur','UP','java')
insert into Studentsss values(8,'soni','nagpur','maharashtra','java')
insert into Studentsss values(9,'tanu','delhi','UP','c')
insert into Studentsss values(10,'somi','jaipur','UP','java')
insert into Studentsss values(11,'sonika','nagpur','maharashtra','c')
select *from 
select *from Studentsss
select *from Studentsss order by name desc

select *from studentsss where rollno>6
select *from studentsss where rollno<9
select *from studentsss where rollno>1 and rollno<9
select *from studentsss where name='anjali'
select *from studentsss where course='java'

select *from studentsss
select *from studentsss where  city='nagpur'
select *from studentsss where state ='UP'
select course,COUNT(*) from studentsss 
where city='nagpur' group by course
select name,COUNT(*) from studentsss where state='UP'
group by name



