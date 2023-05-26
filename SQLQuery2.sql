/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Product_Category_ID]
      ,[Product_Type_Name]
      ,[Product_Gst_ID]
  FROM [fendhal].[dbo].[TableProductCategory]
  select a.CGST,a.SGST ,a.IGST from TableProductGSTDetails a inner join TableProductCategory b on
  a.Product_Gst_ID=a.Product_Gst_ID where Gst_Detail_Name='computer';


