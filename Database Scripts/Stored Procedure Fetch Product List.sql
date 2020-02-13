CREATE PROC SP_Fetch_Product_List
	@user_permission varchar(100), ---- variable to determine which columns the uer has access to
	@key_word varchar(300) ---- key word used to filter the result set during a search for specific products
AS
	BEGIN
		
		IF @user_permission = 'User'
			Select 
				A.fld_product_id,
				A.fld_product_key,
				A.fld_product_name,
				B.fld_brand_name,
				A.fld_product_unit,
				A.fld_product_unit_price,
				A.fld_product_quantity
			From
				Tbl_Products as A 
			left join Tbl_Product_Brands as B on B.fld_brand_id = A.fld_product_brand
			Where
				fld_product_discontinued = 0
			and (
				A.fld_product_key Like '%' + @key_word + '%' or
				A.fld_product_name Like '%' + @key_word + '%' or
				B.fld_brand_name Like '%' + @key_word + '%'
				)
			Order By 
				fld_product_name

		ELSE IF @user_permission = 'Admin' or @user_permission = 'Super'
			Select 
				A.fld_product_id,
				A.fld_product_key,
				A.fld_product_name,
				B.fld_brand_name,
				S.fld_supplier_name,
				A.fld_product_unit,
				A.fld_product_unit_cost,
				A.fld_product_unit_price,
				A.fld_product_quantity,
				A.fld_product_discontinued
			From
				Tbl_Products as A 
			left join Tbl_Product_Brands as B on B.fld_brand_id = A.fld_product_brand
			left join Tbl_Suppliers as S on S.fld_supplier_id = A.fld_product_supplier
			Where (
				A.fld_product_key Like  '%' + @key_word + '%' or
				A.fld_product_name Like '%' + @key_word + '%' or
				B.fld_brand_name Like '%' + @key_word + '%' or
				S.fld_supplier_name Like '%' + @key_word + '%'
				)
			Order By 
				fld_product_name

	END

go

Exec SP_Fetch_Product_List 'Admin', ''






