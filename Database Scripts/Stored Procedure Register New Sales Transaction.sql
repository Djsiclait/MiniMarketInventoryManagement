CREATE PROC SP_Register_New_Sales_Transaction
	@number_of_items int,
	@total decimal(19,0),
	@was_delivery bit, ---- 0 = In store sale; 1 = Delivery
	@username varchar(50),
	@sale_id varchar(300) output
AS
	BEGIN

		Declare @new_sale_id varchar(10)
		exec SP_Generate_New_Id 'Sales', @new_sale_id output

		Insert Into tbl_Sales
		(
			fld_sale_id,
			fld_sale_quantity_items,
			fld_sale_total,
			fld_sale_delivery,
			fld_sold_by
		)
		Values
		(
			@new_sale_id,
			@number_of_items,
			@total,
			@was_delivery,
			@username
		)

		set @sale_id = @new_sale_id

	END

go

Declare @message varchar(300)

exec SP_Register_New_Sales_Transaction 1, 50, 0, 'p.siclait', @message output
exec SP_Register_New_Sales_Transaction 2, 65, 0, 'b.siclait', @message output
exec SP_Register_New_Sales_Transaction 1, 55, 0, 'super.admin', @message output
exec SP_Register_New_Sales_Transaction 3, 90, 1, 'n.siclait', @message output
exec SP_Register_New_Sales_Transaction 5, 256, 0, 'n.siclait', @message output

select * from tbl_Sales

























