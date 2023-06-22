/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Prodid]
      ,[prodname]
      ,[poddes]
      ,[prodrice]
      ,[catid]
      ,[imgname]
	  alter table meesho
	  add prdqty int
  FROM [meesho].[dbo].[meesho]

  select * from meesho