CREATE PROC SP_Register_Sales_Content_FIFO_LIFO
	@product_id varchar(10),
	@brand varchar(100),
	@unit varchar(30),
	@sale_id varchar(10),
	@quantity int,
	@unit_price Decimal(19, 2),
	@format varchar(10)
AS
	BEGIN

		Declare CursorProdructSales Cursor
		For
			Select 
				fld_product_id,
				fld_product_quantity
			From
				Tbl_Products
			Where
				fld_product_name = (select fld_product_name from Tbl_Products where fld_product_id = @product_id)
			and
				fld_product_brand = (select fld_brand_id from Tbl_Product_Brands where fld_brand_name = UPPER(@brand))
			and
				fld_product_unit = UPPER(@unit)
			and 
				fld_product_unit_price = @unit_price
			and 
				fld_product_quantity > 0
			Order By
					CASE 
						WHEN @format = 'LIFO' THEN fld_product_registration_date 
					END DESC, --LIFO
					CASE 
						WHEN @format = 'FIFO' THEN fld_product_registration_date
					END ASC --FIFO

		Declare 
			@current_id varchar(10),
			@old_quantity int

		Open CursorProdructSales

			Fetch Next From CursorProdructSales
				Into
					@current_id,
					@old_quantity

			While @@FETCH_STATUS = 0
				Begin
				
					IF @quantity <= 0
						BREAK
					ELSE
						Begin 
							Insert Into Tbl_Product_Sales
							(
								fld_product_id,
								fld_sale_id,
								fld_product_quantity,
								fld_product_unit_price
							)
							Values
							(
								@current_id,
								@sale_id,
								Case 
									WHEN @old_quantity > @quantity THEN @quantity
									ELSE @old_quantity
								End,
								@unit_price
							)

							Update 
								Tbl_Products
							Set
								fld_product_quantity = (
															CASE 
																WHEN @old_quantity > @quantity THEN @old_quantity - @quantity
																ELSE 0
															END
														)
							Where
								fld_product_id = @current_id

							set @quantity =  (
												CASE 
													WHEN @old_quantity > @quantity THEN 0
													ELSE @quantity - @old_quantity
												END
											)

						End
		 
					Fetch Next From CursorProdructSales
						Into
							@current_id,
							@old_quantity

				End

		Close CursorProdructSales
		Deallocate CursorProdructSales

	END

go

Begin Tran

exec SP_Register_Sales_Content_FIFO_LIFO 'P1', 'RICA', '500 ml', 'S1', 35, 75, 'LIFO'

select * from Tbl_Product_Sales order by fld_sale_id
select * from Tbl_Products where fld_product_name Like '%' + '2%' + '%'

ROLLBACK














