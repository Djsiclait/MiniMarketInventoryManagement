CREATE PROC SP_Fetch_All_Username
	@username varchar(50),
	@user_role varchar(10)
AS
	BEGIN
		
		IF @user_role = 'Admin'
			BEGIN

				Select 
					fld_user_username
				From
					Tbl_Users
				Where
					fld_user_username Like '%' + @username + '%'
				and
					fld_user_username <> 'super.admin'
			END

		IF @user_role = 'Super'
			BEGIN

				Select 
					fld_user_username
				From
					Tbl_Users
				Where
					fld_user_username Like '%' + @username + '%'

			END
		
	END











