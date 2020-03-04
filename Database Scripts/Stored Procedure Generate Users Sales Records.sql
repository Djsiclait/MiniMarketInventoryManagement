CREATE PROC SP_Generate_Users_Sales_Records
	@oldest_date Datetime,
	@newest_date Datetime
AS
	BEGIN
	
		Select
			A.fld_sold_by,
			ISNULL((select COUNT(fld_sale_id) from Tbl_Sales where fld_sold_by = A.fld_sold_by and fld_sale_status = 2 and (fld_sale_date >= @oldest_date and fld_sale_date <= @newest_date)), 0) as 'Returns',
			ISNULL((select SUM(fld_sale_total) from Tbl_Sales where fld_sold_by = A.fld_sold_by and fld_sale_status = 2 and (fld_sale_date >= @oldest_date and fld_sale_date <= @newest_date)), 0) as 'Returns Total',
			ISNULL((select COUNT(fld_sale_id) from Tbl_Sales where fld_sold_by = A.fld_sold_by and fld_sale_status = 0 and (fld_sale_date >= @oldest_date and fld_sale_date <= @newest_date)), 0) as Sales,
			ISNULL((select SUM(fld_sale_total) from Tbl_Sales where fld_sold_by = A.fld_sold_by and fld_sale_status = 0 and (fld_sale_date >= @oldest_date and fld_sale_date <= @newest_date)), 0) as 'Sales Total'
		From 
			Tbl_Sales as A
		Group by
			A.fld_sold_by

	END

go

exec SP_Generate_Users_Sales_Records '2020-01-27', '2020-03-01'












