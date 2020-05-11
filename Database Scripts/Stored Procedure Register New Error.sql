CREATE PROC SP_Register_New_Error
	@code varchar(10),
	@description varchar(300),
	@username varchar(50)
AS
	BEGIN
		
		Insert Into Tbl_Error_Logs
		(
			fld_error_code,
			fld_error_description,
			fld_error_username,
			fld_error_timestamp
		)
		Values
		(
			@code,
			@description,
			@username,
			GETDATE()
		)

	END

go

--exec SP_Register_New_Error 'TEST ERROR', 'This is a test error', 'super.admin'










