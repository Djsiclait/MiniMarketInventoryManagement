CREATE PROC SP_Fetch_Registered_Brand_Names
	@key_word varchar(100)
AS
	BEGIN

		Select 
			fld_brand_name
		From
			Tbl_Product_Brands
		Where
			fld_brand_name <> ''
		and
			fld_brand_name like '%' + @key_word + '%'
	END

go

exec SP_Fetch_Registered_Brand_Names ''









