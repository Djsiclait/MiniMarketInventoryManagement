ALTER PROC SP_Fetch_User_List_Data
	@username varchar(50),
	@user_permission varchar(100),
	@key_word varchar(100)
AS
	BEGIN
		
		IF @user_permission = 'Super'
			Select
				fld_user_username,
				fld_user_first_name,
				fld_user_last_name,
				fld_user_role,
				fld_user_last_login_timestamp,
				fld_user_status
			From
				Tbl_Users
			Where
				fld_user_username <> @username
			and
				(
				fld_user_username Like '%' + @key_word + '%' or
				fld_user_first_name Like '%' + @key_word + '%' or
				fld_user_last_name Like '%' + @key_word + '%' or 
				fld_user_role Like '%' + @key_word + '%' or
				fld_user_status  Like '%' + @key_word + '%'
				)
		ELSE IF @user_permission = 'Admin'
			Select
				fld_user_username,
				fld_user_first_name,
				fld_user_last_name,
				fld_user_role,
				fld_user_last_login_timestamp,
				fld_user_status
			From
				Tbl_Users
			Where
				fld_user_username <> @username
			and
				fld_user_username <> 'super.admin'
			and
				(
				fld_user_username Like '%' + @key_word + '%' or
				fld_user_first_name Like '%' + @key_word + '%' or
				fld_user_last_name Like '%' + @key_word + '%' or 
				fld_user_role Like '%' + @key_word + '%' or
				fld_user_status  Like '%' + @key_word + '%'
				)

	END

go

exec SP_Fetch_User_List_Data 'p.siclait', 'Admin', 'ad'




