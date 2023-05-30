/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [empid]
      ,[name]
      ,[psportno]
      ,[drivingno]
  FROM [school].[dbo].[emp111]
  select  max (psportno)id from emp111 where empid=1;
    select  empid ,max (psportno)id from emp111 group by empid
	select * from emp111
	alter table emp111
	add rollno int;