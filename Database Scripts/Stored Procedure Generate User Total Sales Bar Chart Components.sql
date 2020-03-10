CREATE PROC SP_Generate_User_Total_Sales_Bar_Chart_Components
	@user_role varchar(100),
	@username varchar(50),
	@newest_date Datetime,
	@oldest_date Datetime
AS
	BEGIN
		
		IF @user_role <> 'USER'
			BEGIN
				
				Select 
					Convert(varchar(10), A.fld_sale_date, 103) as 'Log In Date',
					COUNT(A.fld_sale_id) as Sales,
					SUM(A.fld_sale_total) as Total
				From
					Tbl_Sales as A
				Where
					A.fld_sold_by = @username
				and	
					A.fld_sale_status = 0
				and (
					A.fld_sale_date >= @oldest_date and
					A.fld_sale_date <= @newest_date
					)
				Group by 
					Convert(varchar(10), A.fld_sale_date, 103)
				Order by 
					'Log In Date' Desc

			END

	END




























