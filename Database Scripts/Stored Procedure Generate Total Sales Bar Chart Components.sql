CREATE PROC SP_Generate_Total_Sales_Bar_Chart_Components
	@user_role varchar(100),
	@newest_date Datetime,
	@oldest_date Datetime
AS
	BEGIN
		
		IF @user_role <> 'User'
			BEGIN

				Select 
					fld_sold_by,
					COUNT(fld_sale_id) as Sales,
					SUM(fld_sale_total) as Total
				From
					Tbl_Sales
				Where
					fld_sale_status = 0
				and (
					fld_sale_date >= @oldest_date and
					fld_sale_date <= @newest_date
					)
				Group by
					fld_sold_by

			END

	END



























