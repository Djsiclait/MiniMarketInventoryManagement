CREATE PROC SP_Fetch_Product_Information_By_ID
	@product_id varchar(10)
AS
	BEGIN
		
		Select 
			fld_product_key,
			fld_product_name,
			fld_product_brand,
			fld_product_supplier,
			fld_product_unit,
			fld_product_category,
			fld_product_type,
			fld_product_unit_cost,
			fld_product_unit_price,
			fld_product_quantity,
			fld_product_minimum_quantity,
			fld_product_maximum_quantity,
			fld_product_registered_by,
			fld_product_registration_date,
			fld_product_modified_by,
			fld_product_modification_date,
			fld_product_discontinued
		From
			Tbl_Products
		Where
			fld_product_id = @product_id

	END

go

Exec SP_Fetch_Product_Information_By_ID 'P4'


