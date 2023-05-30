CREATE INDEX index_name
ON emp1 (empid, name)



CREATE VIEW school AS
SELECT empid, name 
FROM emp1
WHERE drivingno=33;





SELECT empid
FROM emp1
WHERE drivingno=33
UNION
SELECT empid
FROM emp11
WHERE drivingno=33;
select * from emp1
select * from emp11

select e.empid from emp1 e inner join  emp11 f on
e.empid=f.empid WHERE e.drivingno=33;


select * from emp1
select * from emp11
 select * from state
 select * from city
 SELECT stateid
FROM state
UNION all
SELECT stateid 
FROM city
select e.stateid from state e inner join  city f on
e.stateid=f.stateid;

select * from emp1
select * from emp11