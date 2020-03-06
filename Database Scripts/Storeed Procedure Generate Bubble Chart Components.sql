CREATE PROC SP_Generate_Bubble_Chart_Components
	@username varchar(50),
	@oldest_date Datetime,
	@newest_date Datetime
AS
	BEGIN

		IF @username = 'ALL'
			BEGIN
				
				Select 
					A.fld_user_activity_username,
					Convert(varchar(10), A.fld_user_activity_timestamp, 103) as 'Log In Date', -- source code: https://tableplus.com/blog/2018/09/ms-sql-server-how-to-get-date-only-from-datetime-value.html
					Convert(varchar(8), A.fld_user_activity_timestamp, 108) as 'Log In Time', -- source code: https://stackoverflow.com/questions/7710449/how-to-get-time-from-datetime-format-in-sql/7710495
					DATEDIFF(SECOND, A.fld_user_activity_timestamp, (select ISNULL(MIN(fld_user_activity_timestamp), A.fld_user_activity_timestamp) from Tbl_User_Activity_Logs where fld_user_activity_type = 'LOG OUT' and fld_user_activity_timestamp > A.fld_user_activity_timestamp)) as 'Seconds'
				From 
					Tbl_User_Activity_Logs as A
				Where
					A.fld_user_activity_type = 'LOG IN'
				and (
					A.fld_user_activity_timestamp >= @oldest_date and
					A.fld_user_activity_timestamp <= @newest_date
					)
				Order by
					A.fld_user_activity_timestamp ASC
					
			END
		ELSE
			BEGIN
				
				Select 
					A.fld_user_activity_username,
					Convert(varchar(10), A.fld_user_activity_timestamp, 103) as 'Log In Date', -- source code: https://tableplus.com/blog/2018/09/ms-sql-server-how-to-get-date-only-from-datetime-value.html
					Convert(varchar(8), A.fld_user_activity_timestamp, 108) as 'Log In Time', -- source code: https://stackoverflow.com/questions/7710449/how-to-get-time-from-datetime-format-in-sql/7710495
					DATEDIFF(SECOND, A.fld_user_activity_timestamp, (select ISNULL(MIN(fld_user_activity_timestamp), A.fld_user_activity_timestamp) from Tbl_User_Activity_Logs where fld_user_activity_type = 'LOG OUT' and fld_user_activity_timestamp > A.fld_user_activity_timestamp)) as 'Seconds'
				From 
					Tbl_User_Activity_Logs as A
				Where
					A.fld_user_activity_username = @username
				and
					A.fld_user_activity_type = 'LOG IN'
				and (
					A.fld_user_activity_timestamp >= @oldest_date and
					A.fld_user_activity_timestamp <= @newest_date
					)
				Order by
					A.fld_user_activity_timestamp ASC

			END

	END
























