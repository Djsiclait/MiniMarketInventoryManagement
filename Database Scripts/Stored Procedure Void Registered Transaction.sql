CREATE PROC SP_Void_Registered_Transaction
	@sales_id varchar(10)
AS
	BEGIN
		
		Update 
			Tbl_Sales
		Set
			fld_sale_status = 1 -- Void
		Where
			fld_sale_id = @sales_id

		Declare CursorUpdateSalesContent Cursor 
			For
				Select 
					fld_product_id,
					fld_product_quantity
				From
					Tbl_Product_Sales
				Where
					fld_sale_id = @sales_id

		Declare
			@current_product_id varchar(10),
			@quantity_sold int

		Open CursorUpdateSalesContent

			Fetch Next From CursorUpdateSalesContent
				Into
					@current_product_id,
					@quantity_sold

				While @@FETCH_STATUS = 0
					Begin

						Update 
							Tbl_Products
						Set
							fld_product_quantity = fld_product_quantity + @quantity_sold
						Where
							fld_product_id = @current_product_id
						
						Fetch Next From CursorUpdateSalesContent
							Into
								@current_product_id,
								@quantity_sold

					End

		Close CursorUpdateSalesContent
		Deallocate CursorUpdateSalesContent

	END

go

begin tran

select Top 5 * from Tbl_Products

exec SP_Void_Registered_Transaction 'S6'

select * from Tbl_Sales where fld_sale_id = 'S6'
select Top 5 * from Tbl_Products

rollback

















