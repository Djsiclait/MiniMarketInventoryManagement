CREATE PROC SP_Fetch_Transaction_Information_By_Sales_Id
	@sale_id varchar(10)
AS
	BEGIN
		
		Select 
			fld_sale_id,
			fld_sale_date,
			fld_sale_quantity_items,
			fld_sale_total,
			fld_sale_delivery,
			fld_sale_status,
			fld_sold_by
		From
			Tbl_Sales
		Where
			fld_sale_id = @sale_id

	END

go

exec SP_Fetch_Transaction_Information_By_Sales_Id 'S1'








