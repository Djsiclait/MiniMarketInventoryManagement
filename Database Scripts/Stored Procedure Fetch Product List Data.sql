CREATE PROC SP_Fetch_Product_List_Data
	@user_permission varchar(100) ---- variable to determine which columns the uer has access to
	---- TODO: Add key word input variable for filtered searches
AS
	BEGIN
		
		IF @user_permission = 'User'
			Select 
				fld_product_key,
				fld_product_name,
				fld_product_brand,
				fld_product_unit,
				fld_product_unit_price,
				fld_product_quantity
			From
				Tbl_Products ---- TODO: add left joins with brand, category, type, and supplier tables
			Where
				fld_product_discontinued = 0
		ELSE
			Select 
				fld_product_key,
				fld_product_name,
				fld_product_brand,
				fld_product_supplier,
				fld_product_unit,
				fld_product_unit_cost,
				fld_product_unit_price,
				fld_product_quantity,
				fld_product_discontinued
			From
				Tbl_Products ---- TODO: add left joins with brand, category, type, and supplier tables
			
	END

go

Exec SP_Fetch_Product_List_Data 'User'






