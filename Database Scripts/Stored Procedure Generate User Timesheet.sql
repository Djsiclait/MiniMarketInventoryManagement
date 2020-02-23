CREATE PROC SP_Generate_User_Timesheet
	@newest_date datetime,
	@oldest_date datetime
AS
	BEGIN
		
		Select
			A.fld_user_activity_username,
			(U.fld_user_first_name + ' ' + U.fld_user_last_name) as Name,
			COUNT(A.fld_user_activity_type) / 2 as 'Number of Log Ins',
			dbo.GetAverageLogInTime(A.fld_user_activity_username, @newest_date, @oldest_date) as 'Average Minutes'
		From 
			Tbl_User_Activity_Logs as A
		left Join Tbl_Users as U on U.fld_user_username = A.fld_user_activity_username
		Where
			A.fld_user_activity_type Like 'Log' + '%'
		and (
			A.fld_user_activity_timestamp >= @oldest_date and
			A.fld_user_activity_timestamp <= @newest_date
			)
		Group by
			A.fld_user_activity_username,
			(U.fld_user_first_name + ' ' + U.fld_user_last_name)

	END

go

exec SP_Generate_User_Timesheet '2020-02-23', '2020-02-18'


















