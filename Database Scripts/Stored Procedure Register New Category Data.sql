CREATE PROC SP_Register_New_Category
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

exec SP_Register_New_Category 'Lacteo', @message output
select @message 
exec SP_Register_New_Category 'Bebida', @message output
select @message 
exec SP_Register_New_Category 'Bebe', @message output
select @message 
exec SP_Register_New_Category 'Cereal', @message output
select @message 
exec SP_Register_New_Category 'Pasta', @message output
select @message 
exec SP_Register_New_Category 'Bebida Alcoholica', @message output
select @message 
exec SP_Register_New_Category 'Galleta', @message output
select @message 
exec SP_Register_New_Category 'Panaderia', @message output
select @message 
exec SP_Register_New_Category 'Carne', @message output
select @message 
exec SP_Register_New_Category 'Embutido', @message output
select @message 
exec SP_Register_New_Category 'Pescado', @message output
select @message 
exec SP_Register_New_Category 'Vegetal', @message output
select @message 
exec SP_Register_New_Category 'Frutas', @message output
select @message 

select * from Tbl_Product_Categories










