CREATE PROC SP_Fetch_Users_Activities_Data
	@user_permission varchar(100)
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
				fld_user_activity_username <> 'super.admin'
			Order by 
				fld_user_activity_timestamp Desc

	END

go

exec SP_Fetch_Users_Activities_Data 'Admin'



