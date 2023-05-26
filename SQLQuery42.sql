/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Product_Category_ID]
      ,[Product_Type_Name]
      ,[Product_Gst_ID]
  FROM [fendhal].[dbo].[TableProductCategory]
  select p.Product_Name from TableProduct p inner join TableProductCategory c on p.ProductTypelD=c.Product_Category_ID where c.Product_Type_Name='computer';