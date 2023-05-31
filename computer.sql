create table TableProductGSTDetails(Product_Gst_ID int primary key,Gst_Detail_Name varchar(500),CGST decimal,SGST decimal)
insert into TableProductGSTDetails values(601,'computer',9,9)
insert into TableProductGSTDetails values(602,'mobile',6,6)

----------------------------------------CREATING ANOTHER TABLE------------
create table TableProductCategory(Product_Category_ID int primary key ,Product_Type_Name varchar(500),Product_Gst_ID int,constraint c1 foreign key(Product_Gst_ID)
references TableProductGSTDetails(Product_Gst_ID));
insert into TableProductCategory values(1001,'computer',601)
insert into TableProductCategory values(1002,'mobile',602)


------------------33333333333333333333333333 table--------------------------------
create table TableProduct(ProductlD Int primary key,ProductTypelD Int constraint v1 foreign key (ProductTypelD )
references TableProductCategory(Product_Category_ID),Product_Name varchar(500),Avaiable_Quantity int,Total_Quantity int,price int);
insert into TableProduct values(210,1001,'HP',100,150,2000)
insert into TableProduct values(211,1001,'Dell',90,60,5000)
insert into TableProduct values(212,1002,'Apple',80,100,6000)
insert into TableProduct values(214,1002,'oneplus',160,40,7000)
select * from TableProduct


------------------------------
select p.product_name from TableProduct p inner join TableProductCategory t on p.ProductTypelD = t.Product_Category_ID where t.Product_Type_Name ='printer';

 select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join tableproductcategory b on
 a.product_gst_id = b.product_gst_id where b.Product_Type_Name = 'printer';

 create table TablelnvoiceDetailss(Invoice_Detail_ID int primary key identity,Frist_Name varchar(500),Last_Name varchar(20),Customer_Contact varchar(15),Product_Category_ID int, constraint j2
foreign key(Product_Category_ID) references TableProductCategory(Product_Category_ID),ProductID int constraint j3 foreign key(ProductID) references TableProduct
(ProductlD),Residential_Type_ID int,Invoice_Date DateTime, Gender int,Quantity Decimal,price Decimal ,CGST Decimal,SGST Decimal,CGST_Value Decimal,
SGST_Value Decimal,Total_Amount Decimal)
select * from TablelnvoiceDetailss


select * from TableProductCategory
Select * from TableProduct
select * from TableProductGSTDetails
 select Product_Type_Name from TableProductCategory
 Select p.ProductTypelD,Product_Name from TableProduct p inner join TableProductCategory s on
 p.ProductTypelD=s.Product_Category_Id where Product_Type_Name='mobile';

 Select p.ProductTypelD,Avaiable_Quantity from TableProduct p inner join TableProductCategory s on
 p.ProductTypelD=s.Product_Category_Id where Product_Type_Name='mobile';
 

 select * from TableProduct
 select * from TableProductCategory
 select * from TableProductGSTDetails

 select a.cgst,a.sgst from TableProductGSTDetails a inner join  TableProductCategory b on
 a.Product_Gst_ID=b.Product_Gst_ID where Gst_Detail_Name='computer';
  create table invoicedetails( Product_Category int,Product int,Frist_name varchar(20),Last_name varchar(20),gender int,mobile_number int,Amount_to_pay double,product_name int, avaiable double,total_quantity double,price double,cgst double ,sgst double,date datetime,quantity_requried int,total_price double,cash double,emi double,net_amount double;