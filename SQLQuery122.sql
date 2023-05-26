create table depart(DEPARTMENT_ID int primary key, DEPARTMENT_NAME varchar(20), MANAGER_ID int,
location_id int )
insert into depart values(10,'Administration',200 ,1700 ),
(20 ,'Marketing' , 201 , 1800 ),
(30 ,'Purchasing' , 114  ,1700 ),
(40, 'Human Resources' , 203 ,2400 ),
(50 , 'Shipping' , 121 ,1500 ),
( 60 ,'IT' , 103 ,1400 ),
( 70, 'Public Relations' ,204 ,2700 ),
( 90, 'Public' ,200 ,2900 )
select * from depart


create table empp(EMPLOYEE_ID int, FIRST_NAME varchar(20),LAST_NAME varchar(20), EMAIL varchar(20),
PHONE_NUMBER int, HIRE_DATE int,JOB_ID varchar(20),DOB_ID int, SALARY int,COMMISSION_PCT int,
DEPARTMENT_ID int ,constraint cc1 foreign key (department_id) references depart(department_id));
insert into empp values(100,'Steven','King','SKING',5151234567,2003-06-17,'AD_PRES',24000.00,0.00,0,90),
(101,'Neena','Kochhar','NKOCHHAR',5151234568,2005-09-21,'AD_VP',17000.00,0.00,100,90),
(102,'Lex','De Haan','LDEHAAN',5151234569,2001-01-13,'AD_VP',17000.00,0.00,100,90),
(103,'Alexander','Hunold','AHUNOLD',5904234567,2006-01-03,'IT_PROG',9000.00,0.00,102,60),
(104,'Bruce','Ernst','BERNST',5904234568,2007-05-21,'IT_PROG',6000.00,0.00,103,60),
(105,'David','Austin','DAUSTIN',5904234569,2005-06-25,'IT_PROG',4800.00,0.00,103,60),
(106,'Valli','Pataballa','VPATABAL',5904234560,2006-02-05,'IT_PROG',4800.00,0.00,103,60),
(107,'Diana','Lorentz','DLORENTZ',5904235567,2007-02-07,'IT_PROG',4200.00,0.00,103,60)


Create table location(LOCATION_ID int primary key, STREET_ADDRESS varchar(20),POSTAL_CODE varchar(20), CITY  varchar(20),STATE_PROVINCE varchar(20),
COUNTRY_ID varchar(20))
insert into location values(1400 ,' 2014 Jabberwocky Rd',  26192 ,' Southlake', ' Texas ','US '),
( 1500 , '2011 Interiors Blvd ', 99236 ,' South San Francisco ', 'California' ,' US'),
(1600 ,'2007 Zagora St ', 50090 ,' South Brunswick',' New Jersey','US' ),
(1700 ,' 2004 Charade Rd ',98199 ,'Seattle', 'Washington', 'US' ),
(1800 , '147 Spadina Ave ',' M5V 2L7 ','Toronto' ,'Ontario', 'CA' ),
(1900 , '6092 Boxwood St' , 'YSW 9T2 ', 'Whitehorse' ,'Yukon' , 'CA'),
(2100 , '1298 Vileparle (E)',  490231 ,' Bombay ',' Maharashtra', 'IN' ),
( 2200 , '12-98 Victoria Street' ,2901 , 'Sydney' ,' New South Wales' , 'AU')


 create table grade(GRADE_LEVEL varchar(20),LOWEST_SAL int, HIGHEST_SAL int)
 insert into  grade values('A',1000 ,2999),
('B', 3000 ,5999),
('C', 6000,9999),
('D ',10000, 14999),
('E ',15000 ,24999),
('F', 25000 ,40000)

create  table history( EMPLOYEE_ID int, START_DATE int, END_DATE int, JOB_ID varchar(20), DEPARTMENT_ID int)
insert into history values(102 , 2001-01-13 , 2006-07-24 , 'IT_PROG' , 60 ),
(101 , 1997-09-21 , 2001-10-27 ,'AC_ACCOUNT' , 110 ),
(101 , 2001-10-28 ,2005-03-15 ,'AC_MGR ', 110 ),
(201 , 2004-02-17 , 2007-12-19 ,' MK_REP ', 20 ),
( 114 , 2006-03-24 , 2007-12-31 ,'ST_CLERK ', 50 ),
(122 ,2007-01-01 , 2007-12-31 , 'ST_CLERK' ,50 ),
( 200 , 1995-09-17 , 2001-06-17 , 'AD_ASST' , 90 ),
( 176 , 2006-03-24 , 2006-12-31 ,'SA_REP' , 80 ),
( 176 , 2007-01-01 , 2007-12-31 , 'SA_MAN', 80 ),
( 200 , 2002-07-01 , 2006-12-31 , 'AC_ACCOUNT' ,90)




create table jobs(JOB_ID varchar(20) primary key,JOB_TITLE varchar(20),MIN_SALARY int,MAX_SALARY int)
insert into jobs values('AD_PRES','President',20080,40000),('AD_VP','Administration Vice President',15000,30000),
('AD_ASST','Administration Assistant',3000,6000),('FI_MGR','Finance Manager',8200,16000),('FI_ACCOUNT','Accountant',4200,9000),
('AC_MGR','Accounting Manager',8200,16000),('AC_ACCOUNT','Public Accountant',4200,9000),('SA_MAN','Sales Manager',10000,20080),
('SA_REP','Sales Representative',6000,12008),('PU_MAN','Purchasing Manager',8000,15000),('PU_CLERK','Purchasing Clerk',2500,5500),
('ST_MAN','Stock Manager',5500,8500),('ST_CLERK','Stock Clerk',2008,5000)









create table country(COUNTRY_ID varchar(20), COUNTRY_NAME varchar(20), REGION_ID int)
insert into country values('AR','Argentina', 2 ),
(' AU ', 'Australia ',3) ,
('BE ', 'Belgium', 1 ),
('BR ',' Brazil ', 2 ),
(' CA', 'Canada',  2 ),
('CH ','Switzerland', 1 ),
(' CN ','China ',3 ),
('DE', 'Germany', 1 ),
('DK ',' Denmark ', 1 ),
(' EG', ' Egypt ', 4 ),
(' FR ', 'France', 1 ),
( 'IL',' Israel', 4 )