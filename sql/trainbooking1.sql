select * from trains
select * from trains where train_number like '%32%'
select * from trains where destination like 'b%'
select * from trains where train_time between '12' and  '16'
select * from trains where PNR between '122345'and '127045'
select * from trains where train_name='rajdhani express'
select  train_name from trains 
select  train_name from trains order by train_name desc
select origin,destination,status from trains order by status 
select train_number ,train_name from trains order by train_number desc
select train_number,train_name from trains order by train_number
select distinct destination from trains
select distinct origin ,date,train_time from trains
select train_name,train_number,pnr,date,origin,train_time,status,class from trains where destination='bihar'
select train_name from trains order by LEN (train_name) desc
select origin from trains order by LEN (origin) desc
select * from trains where  origin in (train_time,Date)
select * from trains where  origin in ('nagpur')
select * from trains where origin not in('nagpur')
select * from trains where train_name ='vande bharat express' or train_number='21125'
select * from trains where origin='nagpur' or status='avaiable'
select top 2 train_name from trains order by status  
select top 5 percent train_name from trains order by status  
