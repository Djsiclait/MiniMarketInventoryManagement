CREATE PROC SP_Mark_Transaction_As_Returned
	@sales_id varchar(10),
	@child_id varchar(10),
	@username varchar(50)
AS
	BEGIN
		
		Update 
			Tbl_Sales
		Set
			fld_sale_status = 2, -- Returned
			fld_sale_last_modified = GETDATE(),
			fld_sale_child = @child_id
		Where
			fld_sale_id = @sales_id

		Update
			Tbl_Sales
		Set
			fld_sale_parent = @sales_id
		Where
			fld_sale_id = @child_id

	END

go

exec SP_Mark_Transaction_As_Returned 'S7', 'S8', 'p.siclait'

select * from Tbl_Sales














