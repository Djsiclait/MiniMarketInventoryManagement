CREATE PROC SP_Fetch_Error_Logs
	@key_word varchar(100)
AS
	BEGIN
		
		Select 
			fld_error_code,
			fld_error_description,
			fld_error_username,
			fld_error_timestamp
		From
			Tbl_Error_Logs
		Where
			fld_error_code Like '%' + @key_word + '%'

	END



















