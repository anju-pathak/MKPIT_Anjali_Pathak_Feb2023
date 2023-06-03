select * from emp
select * from emp1
-----top 3=---
select top 3 name from emp Order by name

---MAx--------
select  max( empid) from emp group by psportno;

---alter-
alter table emp
add rollno int;

update emp set rollno='1'  where psportno='8'
-------delete---
delete emp where psportno='22'
---truncate---

truncate  table emp 
-----------drop
drop table emp
-----stored pro---

create procedure  prd111
as
begin
select * from emp1
end;

exec  prd111
----------------view------
create view vs
as
select * from emp1
exec sp_refreshview vs

create index ix
on emp1 (name)
---------------substring------
select
SUBSTRING('anjali',4, 5) result;
SELECT 
    SUBSTRING('SQL Server SUBSTRING', 5, 6) result;


