use AdventureWorks2019
go

create or alter proc
HumanResources.stpr_DepartmentSave
@DepartmentId int,
@Name nvarchar(100),
@Group nvarchar(100)
as
	begin
		declare @resultado as table
		(
		estado int,
		mensaje varchar(500)
		)
		--insercion o actualizacion
		if ISNULL(@DepartmentId,0)=0
			begin
				insert HumanResources.Department (Name,GroupName,ModifiedDate)
				values (@Name,@Group,getdate())
			end
		else
			begin
				update HumanResources.Department set Name=@Name,GroupName=@Group,ModifiedDate=GETDATE() 
				where DepartmentID=@DepartmentID
			end
		insert @resultado values (1,'Registro Guardado')
		select * from @resultado
	end
	go

create or alter proc
Sales.stpr_CreditCardSave

@CreditCardId int,
@CardType nvarchar(100),
@CardNumber nvarchar(50),
@ExpMonth int,
@ExpYear int
as
	begin
		declare @resultado as table
		(	estado int,
			mensaje varchar(500)
		)
		--insercion o actualizacion
		if ISNULL(@CreditCardId,0)=0
			begin
				insert Sales.CreditCard(CardType, CardNumber, ExpMonth, ExpYear, ModifiedDate)
				values (@CardType,@CardNumber,@ExpMonth,@ExpYear,getdate())
			end
		else
			begin
				update Sales.CreditCard
				set CardType=@CardType,CardNumber=@CardNumber,ExpMonth=@ExpMonth,ExpYear=@ExpYear,ModifiedDate=GETDATE() 
				where CreditCardID=@CreditCardId
			end
			insert @resultado values (1,'Registro Guardado')
			select * from @resultado
	end
	go

create or alter proc
Production.stpr_ProductCategorySave
@ProductCategoryId int,
@Name varchar(100)
as
	begin
		declare @resultado as table
		(
		estado int,
		mensaje varchar(500)
		)
		--insercion o actualizacion
		if ISNULL(@ProductCategoryId,0)=0
			begin
				insert Production.ProductCategory(Name,ModifiedDate)
				values (@Name,getdate())
			end
		else
			begin
				update Production.ProductCategory set Name=@Name,ModifiedDate=GETDATE() 
				where ProductCategoryID=@ProductCategoryId
			end
		insert @resultado values (1,'Registro Guardado')
		select * from @resultado
	end
GO

create or alter proc HumanResources.[stpr_DepartmentList]
as
Select top 100 d.DepartmentID, d.Name, d.GroupName
from HumanResources.Department d order by d.ModifiedDate desc
GO

create or alter proc Sales.[stpr_CreditCardList]
as
Select top 100 d.CreditCardID, d.CardType, d.CardNumber, d.ExpMonth, d.ExpYear
from Sales.CreditCard d order by d.ModifiedDate desc
GO

create or alter proc Production.[stpr_ProductCategoryList]
as
Select top 100 d.ProductCategoryID, d.Name
from Production.ProductCategory d order by d.ModifiedDate desc
GO