create table teachers(teacherid int primary key,age int)
create table subject(teacherid int,subject_name varchar(20),constraint t1 foreign key (teacherid) references teachers(teacherid))
insert into teachers values(1,25)
insert into teachers values(2,34)


insert into subject values(1,'computer')
insert into subject values(1,'science')
insert into subject values(2,'maths')
insert into subject values(2,'sst')
select * from teachers
select * from subject