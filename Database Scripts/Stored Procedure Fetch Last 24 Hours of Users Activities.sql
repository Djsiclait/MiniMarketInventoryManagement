CREATE PROC SP_Fetch_Last_24_Hours_Users_Activities_Data
	@user_permission varchar(100),
	@key_word varchar(100)
AS
	BEGIN
		
		IF @user_permission = 'Super'
			Select
				fld_user_activity_username,
				fld_user_activity_description,
				fld_user_activity_type,
				fld_user_activity_timestamp
			From
				Tbl_User_Activity_Logs
			Where
				DATEDIFF(hour, fld_user_activity_timestamp, GETDATE()) <= 24
			and
				(
				fld_user_activity_username Like '%' + @key_word + '%' or 
				fld_user_activity_description Like '%' + @key_word + '%' or
				fld_user_activity_type Like '%' + @key_word + '%' or
				fld_user_activity_timestamp Like '%' + @key_word + '%'
				)
			Order by 
				fld_user_activity_timestamp Desc
		ELSE IF @user_permission = 'Admin'
			Select
				fld_user_activity_username,
				fld_user_activity_description,
				fld_user_activity_type,
				fld_user_activity_timestamp
			From
				Tbl_User_Activity_Logs
			Where
				DATEDIFF(hour, fld_user_activity_timestamp, GETDATE()) <= 24
			and
				fld_user_activity_username <> 'super.admin'
			and
				(
				fld_user_activity_username Like '%' + @key_word + '%' or 
				fld_user_activity_description Like '%' + @key_word + '%' or
				fld_user_activity_type Like '%' + @key_word + '%' or
				fld_user_activity_timestamp Like '%' + @key_word + '%'
				)
			Order by 
				fld_user_activity_timestamp Desc

	END

go

exec SP_Fetch_Last_24_Hours_Users_Activities_Data 'Admin', ''

Select fld_user_activity_type, DATEDIFF(hour, fld_user_activity_timestamp, GETDATE()) As Hours, fld_user_activity_timestamp from Tbl_User_Activity_Logs

