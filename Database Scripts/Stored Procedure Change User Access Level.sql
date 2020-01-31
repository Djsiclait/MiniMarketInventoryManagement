CREATE PROC SP_Change_User_Access_Level
	@target_user varchar(50),
	@new_access_level varchar(100)
AS
	BEGIN
		
		Update 
			Tbl_Users
		Set
			fld_user_role = @new_access_level
		Where
			fld_user_username = @target_user

	END













