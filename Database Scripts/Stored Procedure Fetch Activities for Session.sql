CREATE PROC SP_Fetch_Activities_For_Session
	@username varchar(50),
	@session_start datetime,
	@session_end datetime
AS
	BEGIN

		Select
			fld_user_activity_description,
			fld_user_activity_type,
			fld_user_activity_timestamp
		From
			Tbl_User_Activity_Logs
		Where
			fld_user_activity_username = @username
		and (
			fld_user_activity_timestamp > @session_start and
			fld_user_activity_timestamp < @session_end
			)
		Order by
			fld_user_activity_timestamp ASC

	END

go

exec SP_Fetch_Activities_For_Session 'p.siclait', '2020-02-27', '2020-02-29'


















