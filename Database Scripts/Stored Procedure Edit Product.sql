CREATE PROC SP_Edit_Product_Data
	@product_id varchar(10),
	@new_key varchar(100),
	@new_brand varchar(100),
	@new_supplier varchar(100),
	@new_category varchar(50),
	@new_type varchar(50),
	@new_unit varchar(30),
	@new_cost decimal(19,2),
	@new_price decimal(19,2),
	@new_quantity int,
	@new_minimum int,
	@new_maximum int,
	@new_discontinued bit,
	@username varchar(50),
	@message varchar(300) output
AS
	BEGIN
		
		Declare @response varchar(300)

		---- Brand ID
		Declare @brand_id varchar(10)
		IF exists(select 1 from Tbl_Product_Brands where fld_brand_name = @new_brand)
			set @brand_id = (select fld_brand_id from Tbl_Product_Brands where fld_brand_name = @new_brand)
		ELSE
			BEGIN
				exec SP_Register_New_Brand_Data @new_brand, @response output
				set @brand_id = (select fld_brand_id from Tbl_Product_Brands where fld_brand_name = @new_brand)
			END

		---- Supplier ID
		Declare @supplier_id varchar(10)
		IF exists(select 1 from Tbl_Suppliers where fld_supplier_name = @new_supplier)
			set @supplier_id = (select fld_supplier_id from Tbl_Suppliers where fld_supplier_name = @new_supplier)
		ELSE
			BEGIN
				exec SP_Register_New_Supplier_Data @new_supplier, '', '', @response output
				set @supplier_id = (select fld_supplier_id from Tbl_Suppliers where fld_supplier_name = @new_supplier)
			END

		---- Category ID
		Declare @category_id varchar(10)
		IF exists(select 1 from Tbl_Product_Categories where fld_category_description = @new_category)
			set @category_id = (select fld_category_id from Tbl_Product_Categories where fld_category_description = @new_category)
		ELSE
			BEGIN
				exec SP_Register_New_Category_Data @new_category, @response output
				set @category_id = (select fld_category_id from Tbl_Product_Categories where fld_category_description = @new_category)
			END

		---- Type ID
		Declare @type_id varchar(10)
		IF exists(select 1 from Tbl_Product_Type where fld_type_description = @new_type)
			set @type_id = (select fld_type_id from Tbl_Product_Type where fld_type_description = @new_type)
		ELSE 
			BEGIN
				exec SP_Register_Product_Type @new_type, @response output
				set @type_id = (select fld_type_id from Tbl_Product_Type where fld_type_description = @new_type)
			END

		Update Tbl_Products
		Set
			fld_product_key = @new_key,
			fld_product_brand = @brand_id,
			fld_product_supplier = @supplier_id,
			fld_product_category = @category_id,
			fld_product_type = @type_id,
			fld_product_unit = @new_unit,
			fld_product_unit_cost = @new_cost,
			fld_product_unit_price = @new_price,
			fld_product_quantity = @new_quantity,
			fld_product_minimum_quantity = @new_minimum,
			fld_product_maximum_quantity = @new_maximum,
			fld_product_discontinued = @new_discontinued,
			fld_product_modified_by = @username,
			fld_product_modification_date = GETDATE()
		Where
			fld_product_id = @product_id

		set @message = 'Product updated successfully!'

	END


















