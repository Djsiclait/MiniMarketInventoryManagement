CREATE PROC SP_Fetch_User_Data_By_Username
	@username varchar(50)
AS
	BEGIN
		
		Select 
			fld_user_username,
			fld_user_first_name,
			fld_user_last_name,
			fld_user_role,
			fld_user_status,
			fld_user_creator,
			fld_user_registration_date,
			fld_user_last_login_timestamp
		From
			Tbl_Users
		Where
			fld_user_username = @username

	END

go

exec SP_Fetch_User_Data_By_Username 'b.siclait'











