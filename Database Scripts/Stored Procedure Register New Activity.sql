CREATE PROC SP_Register_New_Activity_Data
	@username varchar(50),
	@description varchar(300),
	@type varchar(100)
AS 
	BEGIN

		Insert Into Tbl_User_Activity_Logs
		(
			fld_user_activity_username,
			fld_user_activity_description,
			fld_user_activity_type
		)
		Values
		(
			@username,
			@description,
			@type
		)

	END










