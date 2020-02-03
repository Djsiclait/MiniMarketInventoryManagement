CREATE PROC SP_Fetch_Registered_Supplier_Names
	@key_word varchar(100)
AS
	BEGIN
		
		Select 
			fld_supplier_name
		From
			Tbl_Suppliers
		Where
			fld_supplier_name Like '%' + @key_word + '%'

	END




















