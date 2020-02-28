CREATE PROC SP_Generate_User_Session_Log
	@username varchar(50),
	@oldest_date datetime,
	@newest_date datetime
AS
	BEGIN

		Select 
			A.fld_user_activity_timestamp as 'Log In',
			(select MIN(fld_user_activity_timestamp) from Tbl_User_Activity_Logs where fld_user_activity_timestamp > A.fld_user_activity_timestamp and fld_user_activity_type = 'LOG OUT') as 'Log Out',
			DATEDIFF(
				MINUTE, 
				A.fld_user_activity_timestamp,
				(select MIN(fld_user_activity_timestamp) from Tbl_User_Activity_Logs where fld_user_activity_timestamp > A.fld_user_activity_timestamp and fld_user_activity_type = 'LOG OUT')) as 'Minutes'
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
			A.fld_user_activity_timestamp Asc

	END

go

exec SP_Generate_User_Session_Log 'p.siclait', '2020-01-01', '2020-02-29' 





















