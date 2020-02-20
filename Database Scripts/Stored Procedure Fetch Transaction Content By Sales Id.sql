CREATE PROC SP_Fetch_Transaction_Content_By_Sales_Id
	@sale_id varchar(10)
AS
	BEGIN
		
		Select 
			A.fld_product_id,
			B.fld_product_name,
			C.fld_brand_name,
			B.fld_product_unit,
			A.fld_product_quantity,
			A.fld_product_unit_price,
			(A.fld_product_quantity * A.fld_product_unit_price) AS total
		From
			Tbl_Product_Sales as A
		left join Tbl_Products as B on B.fld_product_id = A.fld_product_id 
		left join Tbl_Product_Brands as C on C.fld_brand_id = B.fld_product_brand
		Where
			fld_sale_id = @sale_id

	END

go

exec SP_Fetch_Transaction_Content_By_Sales_Id 'S12'






















