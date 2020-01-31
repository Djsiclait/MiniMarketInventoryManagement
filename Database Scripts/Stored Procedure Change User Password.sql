CREATE PROC SP_Change_User_Password
	@username varchar(50),
	@new_password varchar(30)
AS
	BEGIN

		Update
			Tbl_Users
		Set
			fld_user_password = @new_password
		Where
			fld_user_username = @username

	END















