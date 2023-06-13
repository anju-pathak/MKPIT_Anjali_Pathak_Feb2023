create table item_master(item_id int primary key identity, item_name varchar(20) not null,category varchar(20) not null,rate decimal,
balance_quantity int not null);


create table department_mast(department_id int primary key identity,department_Name varchar(20) not null);



create table vendor_mast(vendor_id int primary key identity,vender_name varchar(20) not null);


 create table tranaction(tranaction_id int primary key identity,item_id int constraint i1 foreign key (item_id) references item_master(item_id),
 transaction_date datetime not null,department_id int null constraint d1 foreign key(department_id) references
 department_mast(department_id),vendor_id int  null constraint v1 foreign key(vendor_id) references
 vendor_mast(vendor_id), quantity int not null)

