CREATE PROC SP_Register_New_Product_Data
	@key varchar(100),
	@name varchar(300),
	@brand varchar(100),
	@supplier varchar(100),
	@unit varchar(30),
	@category varchar(50),
	@type varchar(50),
	@cost decimal(19,2),
	@price decimal(19,2),
	@quantity int,
	@minimum int,
	@maximum int,
	@username varchar(50),
	@message varchar(300) output
AS
	BEGIN

		IF exists (select 1 from Tbl_Products where fld_product_name = @name and fld_product_brand = @brand and fld_product_supplier = @supplier and fld_product_category = @category and fld_product_type = @type and fld_product_unit_cost = @cost)
			set @message = 'This product is already registered with the same informations'
		ELSE
			BEGIN
			
				Declare @response varchar(300)

				---- Category ID
				Declare @category_id varchar(10)
				IF exists(select 1 from Tbl_Product_Categories where fld_category_description = @category)
					set @category_id = (select fld_category_id from Tbl_Product_Categories where fld_category_description = @category)
				ELSE
					BEGIN
						exec SP_Register_New_Category_Data @category, @response output
						set @category_id = (select fld_category_id from Tbl_Product_Categories where fld_category_description = @category)
					END

				---- Type ID
				Declare @type_id varchar(10)
				IF exists(select 1 from Tbl_Product_Type where fld_type_description = @type)
					set @type_id = (select fld_type_id from Tbl_Product_Type where fld_type_description = @type)
				ELSE 
					BEGIN
						exec SP_Register_Product_Type @type, @response output
						set @type_id = (select fld_type_id from Tbl_Product_Type where fld_type_description = @type)
					END

				Declare @new_product_id varchar(10)
				exec SP_Generate_New_Id 'Products', @new_product_id output
				
				Insert Into Tbl_Products
				(
					fld_product_id,
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
					fld_product_modified_by
				)
				Values
				(
					@new_product_id,
					@key,
					@name,
					(select fld_brand_id from Tbl_Product_Brands where fld_brand_name = @brand),
					(select fld_supplier_id from Tbl_Suppliers where fld_supplier_name = @supplier),
					@unit,
					@category_id,
					@type_id,
					@cost,
					@price,
					@quantity,
					@minimum,
					@maximum,
					@username,
					@username
				) 

				set @message = 'Product created successfully!'

			END

	END

go

Declare @message varchar(300)

--exec SP_Register_New_Product_Data '', 'Leche Descremada 2%', 'B1', 'S1', '500 ml', 'C1', 'T2', 35.00, 75.00, 40, 10, 50, 'p.siclait', @message output
--exec SP_Register_New_Product_Data 'Sin Lactosa', 'Leche Sin Lactosa', 'B1', 'S1', '1000 ml', 'C1', 'T2', 45.00, 85.00, 45, 5, 30, 'b.siclait', @message output
--exec SP_Register_New_Product_Data '', 'Leche Descremada 2%', 'B1', 'S2', '500 ml', 'C1', 'T2', 35.00, 75.00, 10, 10, 50, 'p.siclait', @message output
--exec SP_Register_New_Product_Data 'Coronita', 'Corona', 'B3', 'S3', '255 ml', 'C3', 'T3', 40.00, 80.00, 68, 50, 100, 'n.siclait', @message output
--exec SP_Register_New_Product_Data '', 'Sazon Completo Multi Vitaminas', 'B2', 'S2', 'unidad', 'C1', 'T2', 1.00, 7.00, 150, 200, 400, 'super.admin', @message output
--exec SP_Register_New_Product_Data 'Pasta Nacional', 'Espagheti La Nacional', 'B2', 'S2', '16 oz', 'C4', 'T4', 10.00, 15.00, 8, 10, 30, 'super.admin', @message output
--exec SP_Register_New_Product_Data '', 'Espagheti La Famosa', 'B2', 'S2', '32 oz', 'C4', 'T4', 25.00, 23.00, 40, 20, 30, 'super.admin', @message output

select * from Tbl_Products














