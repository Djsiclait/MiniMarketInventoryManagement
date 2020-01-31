CREATE PROC SP_Change_User_Status
	@target_user varchar(50),
	@new_status varchar(100)
AS
	BEGIN
	
		Update 
			Tbl_Users
		Set
			fld_user_status = @new_status
		Where
			fld_user_username = @target_user

	END










