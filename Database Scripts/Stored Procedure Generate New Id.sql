CREATE PROC SP_Generate_New_Id
	@table varchar(100),
	@generatedId varchar(10) output
AS
	BEGIN

		Declare 
			@referencePrefix varchar(4),
			@referenceIterator int
		
		set @referencePrefix = (select fld_id_reference_id from tbl_id_reference_logs where fld_id_reference_table = @table)
		set @referenceIterator = (select fld_id_reference_iteration from tbl_id_reference_logs where fld_id_reference_table = @table) + 1

		Update 
			Tbl_Id_Reference_Logs
		set
			fld_id_reference_iteration = @referenceIterator
		where
			fld_id_reference_table = @table

		set @generatedId = @referencePrefix + '' + CAST(@referenceIterator as varchar) 

	END

go


Begin Tran
declare @newId varchar(10)

exec SP_Generate_New_Id 'Products', @newId output
select @newId
exec SP_Generate_New_Id 'Products', @newId output
select @newId
exec SP_Generate_New_Id 'Products', @newId output
select @newId

exec SP_Generate_New_Id 'Suppliers', @newId output
select @newId
exec SP_Generate_New_Id 'Suppliers', @newId output
select @newId

exec SP_Generate_New_Id 'Sales', @newId output
select @newId
exec SP_Generate_New_Id 'Sales', @newId output
select @newId
exec SP_Generate_New_Id 'Sales', @newId output
select @newId

select * from tbl_id_reference_logs
ROLLBACK





