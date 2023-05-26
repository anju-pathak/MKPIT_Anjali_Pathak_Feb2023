create table TableProductGSTDetails(Product_Gst_ID int primary key,Gst_Detail_Name varchar(500),CGST decimal,SGST decimal,IGST decimal)
insert into TableProductGSTDetails values(601,'Ac and fridge',14,14,14)
insert into TableProductGSTDetails values(602,'computer',9,9,9)
insert into TableProductGSTDetails values(603,'printer',9,9,9)
insert into TableProductGSTDetails values(604,'mobile',6,6,6)

----------------------------------------CREATING ANOTHER TABLE------------
create table TableProductCategory(Product_Category_ID int primary key ,Product_Type_Name varchar(500),Product_Gst_ID int,constraint c1 foreign key(Product_Gst_ID)
references TableProductGSTDetails(Product_Gst_ID));
insert into TableProductCategory values(1001,'computer',602)
insert into TableProductCategory values(1002,'mobile',604)
insert into TableProductCategory values(1003,'printer',603)
insert into TableProductCategory values(1004,'Ac and frigde',601)

------------------33333333333333333333333333 table--------------------------------
create table TableProduct(ProductlD Int primary key,ProductTypelD Int constraint v1 foreign key (ProductTypelD )
references TableProductCategory(Product_Category_ID),Product_Name varchar(500));
insert into TableProduct values(210,1002,'Apple')
insert into TableProduct values(211,1002,'Lenvo')
insert into TableProduct values(212,1003,'Sumsung')
insert into TableProduct values(214,1004,'LG')
insert into TableProduct values(215,1001,'Sony')

------------------------------
create table TablelnvoiceDetails(Invoice_Detail_ID int primary key,Customer_Name varchar(500),Customer_Contact varchar(15),Product_Category_ID int, constraint c2 
foreign key(Product_Category_ID) references TableProductCategory(Product_Category_ID),ProductID int constraint c3 foreign key(ProductID) references TableProduct
(ProductlD),Residential_Type_ID int,Invoice_Date DateTime,Quantity Decimal,price Decimal ,CGST Decimal,SGST Decimal,IGST Decimal,CGST_Value Decimal,
SGST_Value Decimal,IGST_Value Decimal,Total_Amount Decimal)
insert into TablelnvoiceDetails values(1,'Rahul',987654321,1002,210,3001,2002-04-4,1,50000,6,6,12,3000,3000,6000,56000)
insert into TablelnvoiceDetails values(2,'nikita',987654322,1001,211,3002,2002-08-4,1,65000,9,9,12,11700,5850,5850,76000)
insert into TablelnvoiceDetails values(12,'gopal',987654311,1001,215,3003,2002-12-4,1,60000,9,9,12,5400,54000,10800,70000)
insert into TablelnvoiceDetails values(13,'anand',987654331,1002,210,3004,2002-02-4,1,40000,6,6,12,2400,2400,24000,42000)

select p.product_name from TableProduct p inner join TableProductCategory t on p.ProductTypelD = t.Product_Category_ID where t.Product_Type_Name ='printer';

 select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join tableproductcategory b on
 a.product_gst_id = b.product_gst_id where b.Product_Type_Name = 'printer';

 create table TablelnvoiceDetailss(Invoice_Detail_ID int primary key identity,Customer_Name varchar(500),Customer_Contact varchar(15),Product_Category_ID int, constraint j2
foreign key(Product_Category_ID) references TableProductCategory(Product_Category_ID),ProductID int constraint j3 foreign key(ProductID) references TableProduct
(ProductlD),Residential_Type_ID int,Invoice_Date DateTime,Quantity Decimal,price Decimal ,CGST Decimal,SGST Decimal,IGST Decimal,CGST_Value Decimal,
SGST_Value Decimal,IGST_Value Decimal,Total_Amount Decimal)
