create table children (id int,name varchar(20),last_name varchar(20),city varchar(20),state varchar(20),course varchar(20))
insert into children values(1,'anjali','pathak','nagpur','maharashtra','java')
insert into children values(2,'mona','mohatkar','nagpur','maharashtra','dotnet')
insert into children values(3,'tanushri','meshram','kuhi','maharashtra','dotnet')
insert into children values(4,'karishma','panchdhare','nagpur','maharashtra','java')
insert into children values(5,'ashish','lilhare','chandrapur','maharashtra','dotnet')
insert into children values(6,'jay','deshmukh','amravati','maharashtra','java')
insert into children values(7,'shreya','dakhale','nagpur','maharashtra','c')
insert into children values(8,'rupali','barde','amravati','maharashtra','c')
insert into children values(9,'mayuri','pal','nagpur','maharashtra','dotnet')
insert into children values(10,'akansha','whane','nagpur','maharashtra','java')
insert into children values(11,'yasmin','sheikh','chandrapur','maharashtra','java')
insert into children values(12,'tanmay','patil','nagpur','maharashtra','c')
insert into children values(13,'sahil','kalwe','nagpur','maharashtra','java')
select *from children
select *from children where name='anjali'
select *from children where city='nagpur'
select *from children where course='dotnet'
select *from children where id=7
select *from children where id>5 and id<9
select *from children  order  by name desc
select course,COUNT(*) from children where city='nagpur' group by course
select city,COUNT(*) from children where state='maharashtra'


