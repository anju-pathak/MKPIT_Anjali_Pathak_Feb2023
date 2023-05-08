
 insert into trains values('maharaja express',21325,122345,12-12-23,'nagpur','bihar','avaiable','general','tatkal')
 insert into trains values('maharaja express',21325,122345,12-12-23,'nagpur','bihar',12.00,'avaiable','general','tatkal')
 
 insert into trains values('maharaja express',21325,122345,12-12-23,'nagpur','bihar',12.00,'avaiable','general','tatkal')
 insert into trains values('Shatabdi Express',21324,129345,15-12-23,'nagpur','mumbai',16.00,'avaiable','3AC','tatkal')
 insert into trains values('Rajdhani Express',21329,122349,16-12-23,'delhi','bihar',13.40,'waiting','2AC','ladies')
 insert into trains values('Vande Bharat Express',21925,199345,11-12-23,'kolkata','bihar',11.00,'waiting','1AC','tatkal')
 insert into trains values('Azad Hind Express',21125,122345,12-12-23,'howrah','pune',6.00,'avaiable','general','VIP')
 insert into trains values('Avantika Express',11325,122340,12-12-23,'indore','bihar',10.00,'waiting','sleeper','general')
 insert into trains values('Bagmati Express',21325,122345,14-12-23,'mysore','darbhanga',19.00,'avaiable','sleeper','tatkal')
 insert into trains values('Sinhagad Express',23325,122045,12-12-23,'gujrat','patna',18.00,'waiting','general','ladies')
  insert into trains values('Poorna express',23335,127045,13-12-23,'Buxar','pune',18.00,'avaiable','sleeper','tatkal')
  select * from trains where origin ='nagpur'
  select * from trains
  create table route( name varchar(20),price varchar(20),PNR int,origin varchar(20))
  insert into route values('nagpur',500,122345,'nagpur'),('kanpur',600,129345,'nagpur'),
  ('bihar',700,122349,'mumbai'),('nagpur',300,122345,'kanpur'),('howrah',500,122345,'nagpur'),
  ('patna',200,122335,'bihar'),('buxar',900,127045,'pune')
  select * from route
-------------------right join-----------------
select trains.train_name,trains.train_number,trains.PNR,trains.origin,
route.name,route.price,route.PNR,route.origin from trains right join route on trains.PNR=route.PNR
-------------------right join-----------------

-------------------left join-----------------
select trains.train_name,trains.train_number,trains.PNR,route.PNR,route.origin from trains
left join route on trains.origin=route.origin

-------------------left join-----------------

-------------------full join-----------------
select trains.train_name,trains.train_number,trains.PNR,trains.origin,
route.name,route.price,route.PNR,route.origin from trains full join route on trains.PNR=route.PNR
-------------------cross join-----------------
select trains.train_name,trains.train_number,trains.PNR,trains.origin,
route.name,route.price,route.PNR,route.origin from trains cross join route where trains.PNR=route.PNR
-------------------inner join-----------------
select trains.train_name,trains.train_number,trains.PNR,trains.origin,
route.name,route.price,route.PNR,route.origin from trains inner join route on trains.PNR=route.PNR
