CREATE PROC SP_Register_New_Brand
	@name varchar(100),
	@message varchar(300) output
AS
	BEGIN
		
		IF exists(select 1 from Tbl_Product_Brands where fld_brand_name = @name)
			set @message = 'This brand has already been registered'
		ELSE
			BEGIN

				Declare @new_brand_id varchar(10)
				exec SP_Generate_New_Id 'Product Brands', @new_brand_id output

				Insert Into Tbl_Product_Brands
				(
					fld_brand_id,
					fld_brand_name
				)
				Values
				(
					@new_brand_id,
					@name
				)

				set @message = 'Brand has been registered successfully!'

			END

	END

go

Declare @message varchar(300)

exec SP_Register_New_Brand '', @message output
select @message
exec SP_Register_New_Brand 'Rica', @message output
select @message
exec SP_Register_New_Brand 'Maggi', @message output
select @message
exec SP_Register_New_Brand 'Presidente', @message output
select @message
exec SP_Register_New_Brand 'Goya', @message output
select @message
exec SP_Register_New_Brand 'La Famosa', @message output
select @message
exec SP_Register_New_Brand 'Colgate', @message output
select @message

select * from Tbl_Product_Brands









