CREATE PROC SP_Register_New_Category_Data
	@description varchar(50),
	@message varchar(300) output
AS
	BEGIN
	
		IF exists(select 1 from Tbl_Product_Categories where fld_category_description = @description)
			set @message = 'This category is already registered'
		ELSE 
			BEGIN

				Declare @new_category_id varchar(10)
				exec SP_Generate_New_Id 'Product Categories', @new_category_id output
		
				Insert Into Tbl_Product_Categories
				(
					fld_category_id,
					fld_category_description
				)
				Values 
				(
					@new_category_id,
					UPPER(@description)
				)

				set @message = 'Supplier has been registered successfully!'

			END
	END

go

Declare @message varchar(300)

exec SP_Register_New_Category_Data 'Lacteo', @message output
select @message 
exec SP_Register_New_Category_Data 'Bebida', @message output
select @message 
exec SP_Register_New_Category_Data 'Bebe', @message output
select @message 
exec SP_Register_New_Category_Data 'Cereal', @message output
select @message 
exec SP_Register_New_Category_Data 'Pasta', @message output
select @message 
exec SP_Register_New_Category_Data 'Bebida Alcoholica', @message output
select @message 
exec SP_Register_New_Category_Data 'Galleta', @message output
select @message 
exec SP_Register_New_Category_Data 'Panaderia', @message output
select @message 
exec SP_Register_New_Category_Data 'Carne', @message output
select @message 
exec SP_Register_New_Category_Data 'Embutido', @message output
select @message 
exec SP_Register_New_Category_Data 'Pescado', @message output
select @message 
exec SP_Register_New_Category_Data 'Vegetal', @message output
select @message 
exec SP_Register_New_Category_Data 'Frutas', @message output
select @message 

select * from Tbl_Product_Categories










