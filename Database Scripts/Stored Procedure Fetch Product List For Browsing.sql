CREATE PROC SP_Fetch_Product_List_For_Browsing
	@user_permission varchar(100), ---- variable to determine which columns the uer has access to
	@key_word varchar(300), ---- key word used to filter the result set during a search for specific products
	@format varchar(10) ---- inventory management accounting system to organize the catalog according to LIFO and FIFO 
AS
	BEGIN
		
		IF @user_permission = 'User'
			Select
				MAX(A.fld_product_key) as product_key,
				A.fld_product_name,
				B.fld_brand_name,
				A.fld_product_unit,
				Max(A.fld_product_unit_price) as unit_price,
				Sum(A.fld_product_quantity) as quantity
			From
				Tbl_Products as A 
			left join Tbl_Product_Brands as B on B.fld_brand_id = A.fld_product_brand
			Where
				A.fld_product_discontinued = 0
			and (
				A.fld_product_key Like '%' + @key_word + '%' or
				A.fld_product_name Like '%' + @key_word + '%' or
				B.fld_brand_name Like '%' + @key_word + '%'
				)
			Group By
				A.fld_product_name,
				B.fld_brand_name,
				A.fld_product_unit
			Order By 
				A.fld_product_name

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
				A.fld_product_discontinued,
				A.fld_product_registration_date
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
				A.fld_product_name,
				CASE 
					WHEN @format = 'LIFO' THEN A.fld_product_registration_date 
				END ASC, --LIFO
				CASE 
					WHEN @format = 'FIFO' THEN A.fld_product_registration_date
				END DESC --FIFO

	END

go

Exec SP_Fetch_Product_List_For_Browsing 'Admin', '2%', 'LIFO'
Exec SP_Fetch_Product_List_For_Browsing 'User', '2%', 'FIFO'






