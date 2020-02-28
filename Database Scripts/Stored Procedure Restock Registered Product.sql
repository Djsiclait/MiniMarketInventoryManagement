CREATE PROC SP_Restock_Registered_Product
	@product_id varchar(10),
	@added_units int,
	@username varchar(50),
	@message varchar(300) output
AS
	BEGIN
			
		IF Not exists(select 1 from Tbl_Products where fld_product_id = @product_id)
			set @message = 'This product has not been registered'
		ELSE
			BEGIN
			
				Update 
					Tbl_Products
				Set
					fld_product_quantity = fld_product_quantity + @added_units,
					fld_product_modified_by = @username,
					fld_product_modification_date = GETDATE()
				Where
					fld_product_id = @product_id
				

				set @message = 'Product has been restocked successfully!'

			END

	END

go 

begin tran 

declare @message varchar(300)

select fld_product_quantity from Tbl_Products where fld_product_id = 'P6'

exec SP_Restock_Registered_Product 'P6', 9, 'p.siclait', @message output

select fld_product_quantity from Tbl_Products where fld_product_id = 'P6'

rollback
















