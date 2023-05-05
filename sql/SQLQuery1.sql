create table movies(moviename varchar(20) primary key,showtime int,showdata int)
create table pictures(moviename varchar(20),theatrename varchar(20),seatno int,constraint p1 foreign key(moviename) references movies(moviename))
insert into movies values('khakhi', 12.00,13-12-23)
insert into movies values('pusha', 11.00,13-12-23)
insert into movies values('pk', 12.00,15-12-23)
insert into movies values('welcome', 19.00,17-12-23)
insert into movies values('delhi6', 16.00,19-12-23)

insert into pictures values('khakhi','inox',12)
insert into pictures values('khakhi','sudama',15)
insert into pictures values('pusha','libarty',11)
insert into pictures values('pusha','smariti',10)
insert into pictures values('pk','janki',1)
insert into pictures values('welcome','pvr',20)
insert into pictures values('delhi6','panchsheel',21)
select * from movies
select * from pictures