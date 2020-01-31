CREATE PROC SP_Register_Last_Login_Data
	@username varchar(50)
AS
	BEGIN

		Update 
			Tbl_Users
		set
			fld_user_last_login_timestamp = GETDATE()
		Where
			fld_user_username = @username

	END

go 

exec SP_Register_Last_Login_Data 'n.siclait'
exec SP_Register_Last_Login_Data 'p.siclait'

select * from Tbl_Users






