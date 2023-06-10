select * from fee
select * from emp111

select psportno max  from emp111 order by name



create view vi
as
select empid from emp111

exec sp_refreshview vi

select * from vi
ALTER TABLE emp111
DROP COLUMN rollno;

select * from emp111
union
select * from emp12;


select * from emp111
union all
select * from emp12; 

select * from emp111,emp12;