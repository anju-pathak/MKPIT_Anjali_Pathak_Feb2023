create table movie(movie_name varchar(20),theater varchar(20),price varchar(20),time varchar(20),date varchar(20),seatno int)
insert into movie values('chupke chupke','inox',250,12.00,12-12-23,12)
select * from movie
insert into movie values('khakhi','pvr',260,15.00,12-12-23,17)
insert into movie values('panchayat','sudama',200,12.00,12-12-23,19)
insert into movie values('welcome','liberty',240,12.00,12-12-23,12)
insert into movie values('krishna cottage','smriti',230,12.00,12-12-23,11)
select * from movie where price between '200' and'250'
select * from movie where price=  '200' 
select * from movie order by movie_name desc 
select * from movie order by price desc 
select movie_name,theater from movie order by price
select movie_name,theater from movie order by price desc
select * from movie where movie_name like '%el%'
select * from movie where time ='15' or seatno='19'
select * from movie where movie_name='khakhi'
select top 3 movie_name from movie 
select distinct seatno from movie order by seatno