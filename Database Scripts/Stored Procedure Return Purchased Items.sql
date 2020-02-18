CREATE PROC SP_Return_Purchased_Items
	@sales_id varchar(10),
	@product_id varchar(10),
	@quantity int,
	@username varchar(50)
AS
	BEGIN

		Update
			Tbl_Products
		Set
			fld_product_quantity = fld_product_quantity + @quantity,
			fld_product_modification_date = GETDATE(),
			fld_product_modified_by = @username
		Where
			fld_product_id = @product_id

	END

go 

begin tran

select * from Tbl_Products where fld_product_id = 'P5'
exec SP_Return_Purchased_Items 'S10', 'P5', 2, 'b.siclait'
select * from Tbl_Products where fld_product_id = 'P5'

rollback





















