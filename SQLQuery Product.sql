/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductId]
      ,[ProductName]
      ,[CategoryId]
      ,[CategoryName]
  FROM [Productdb].[dbo].[EmployeeModels]