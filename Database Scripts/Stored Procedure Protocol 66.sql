CREATE PROC SP_Protocol_66

AS
	BEGIN
		
		Declare 
			@activity_type varchar(100)

		set @activity_type = (select Top 1 fld_user_activity_type from Tbl_User_Activity_Logs order by fld_user_activity_timestamp DESC)

		IF @activity_type <> 'LOG OUT'
			BEGIN
				
				Declare 
					@last_user varchar(50),
					@last_timestamp Datetime

				set @last_user = (select Top 1 fld_user_activity_username from Tbl_User_Activity_Logs order by fld_user_activity_timestamp DESC)
				set @last_timestamp = (select Top 1 fld_user_activity_timestamp from Tbl_User_Activity_Logs order by fld_user_activity_timestamp DESC)

				Insert Into Tbl_User_Activity_Logs
				(
					fld_user_activity_username,
					fld_user_activity_description,
					fld_user_activity_timestamp,
					fld_user_activity_type	
				)
				Values
				(
					@last_user,
					'System Protocol 66 for unsuccessful log out by user, ' + @last_user,
					@last_timestamp,
					'LOG OUT'
				)

			END

	END


























