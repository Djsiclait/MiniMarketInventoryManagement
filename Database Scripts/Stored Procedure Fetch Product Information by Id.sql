CREATE PROC SP_Fetch_Product_Information_By_ID
	@product_id varchar(10)
AS
	BEGIN
		
		Select 
			A.fld_product_key,
			A.fld_product_name,
			B.fld_brand_name,
			S.fld_supplier_name,
			A.fld_product_unit,
			C.fld_category_description,
			T.fld_type_description,
			A.fld_product_unit_cost,
			A.fld_product_unit_price,
			A.fld_product_quantity,
			A.fld_product_minimum_quantity,
			A.fld_product_maximum_quantity,
			A.fld_product_registered_by,
			A.fld_product_registration_date,
			A.fld_product_modified_by,
			A.fld_product_modification_date,
			A.fld_product_discontinued
		From
			Tbl_Products as A
		left join Tbl_Product_Brands as B on B.fld_brand_id = A.fld_product_brand
		left join Tbl_Suppliers as S on S.fld_supplier_id = A.fld_product_supplier
		left join Tbl_Product_Categories as C on C.fld_category_id = A.fld_product_category
		left join Tbl_Product_Type as T on T.fld_type_id = a.fld_product_type
		Where
			fld_product_id = @product_id

	END

go

Exec SP_Fetch_Product_Information_By_ID 'P1'


