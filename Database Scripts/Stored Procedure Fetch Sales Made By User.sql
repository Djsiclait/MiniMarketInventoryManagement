CREATE PROC SP_Fetch_Sales_Made_By_User
	@username varchar(50),
	@oldest_date Datetime,
	@newest_date Datetime
AS
	BEGIN

		Select 
			fld_sale_id,
			fld_sale_date,
			fld_sale_quantity_items,
			fld_sale_total,
			fld_sale_parent
		From
			Tbl_Sales
		Where
			fld_sold_by = @username
		and
			fld_sale_status = 0
		and (
			fld_sale_date >= @oldest_date and
			fld_sale_date <= @newest_date
			)
		Order by
			fld_sale_date ASC

	END

go

exec SP_Fetch_Sales_Made_By_User 'super.admin', '2020-01-31', '2020-03-03'












