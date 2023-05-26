/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductlD]
      ,[ProductTypelD]
      ,[Product_Name]
      ,[price]
  FROM [fendhal].[dbo].[TableProduct]
  select * from TableProduct;
  select * from TableProductCategory;
  select * from TableProductGSTDetails;
  
  select p.Product_Name from TableProduct p inner join TableProductCategory s
  on p.ProductTypelD=s.Product_Category_ID where Product_Type_Name='computer';

  select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join TableProductCategory b on
  a.Product_Gst_ID=a.Product_Gst_ID where Product_Type_Name ='computer';
  select price from TableProduct;