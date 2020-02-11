CREATE PROC SP_Fetch_Sales_Records 
	@key_word varchar(100)
AS
	BEGIN

		Select 
			fld_sale_id,
			fld_sale_quantity_items,
			fld_sale_total,
			fld_sold_by,
			fld_sale_date,
			fld_sale_delivery,
			fld_sale_status
		From
			tbl_Sales
		Where
			(
			fld_sale_id Like '%' + @key_word + '%' or
			fld_sale_date Like '%' + @key_word + '%' or
			fld_sold_by Like '%' + @key_word + '%' or 
			fld_sale_status Like '%' + @key_word + '%'
			)
		Order By
			fld_sale_date 

	END

go

exec SP_Fetch_Sales_Records 'S2'


















