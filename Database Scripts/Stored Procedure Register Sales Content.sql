CREATE PROC SP_Register_Sales_Content
	@product_id varchar(10),
	@sale_id varchar(10),
	@quantity int,
	@unit_price Decimal(19, 2)
AS
	BEGIN
		
		Insert Into Tbl_Product_Sales
		(
			fld_product_id,
			fld_sale_id,
			fld_product_quantity,
			fld_product_unit_price
		)
		Values
		(
			@product_id,
			@sale_id,
			@quantity,
			@unit_price
		)

		Update
			Tbl_Products
		Set 
			fld_product_quantity = fld_product_quantity - @quantity
		Where
			fld_product_id = @product_id

	END

go

Begin Tran

exec SP_Register_Sales_Content 'P1', 'S1', 20, 75

select * from Tbl_Product_Sales
select * from Tbl_Products

ROLLBACK














