---- Source code: https://stackoverflow.com/questions/14506871/how-to-execute-a-stored-procedure-inside-a-select-query/43946983
CREATE FUNCTION GetAverageLogInTime(@username varchar(50), @newest_date datetime, @oldest_date datetime) RETURNS Decimal
AS
	BEGIN

		DECLARE @average_time decimal(10,2)

		---- Cursor
		Declare CalculateAverage Cursor
			For
				Select 
					A.fld_user_activity_timestamp, --- Login time
					(select ISNULL(MIN(fld_user_activity_timestamp), A.fld_user_activity_timestamp) from Tbl_User_Activity_Logs where fld_user_activity_type = 'LOG OUT' and fld_user_activity_timestamp > A.fld_user_activity_timestamp)
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

		Declare 
			@current_login_time Datetime,
			@current_logout_time Datetime,
			@count decimal,
			@total decimal 

		set @count = 0.0
		set @total = 0.0

		OPEN CalculateAverage

		FETCH NEXT FROM CalculateAverage
			INTO
			@current_login_time,
			@current_logout_time

		WHILE @@FETCH_STATUS = 0
			BEGIN
				
				set @count = @count + 1.0

				set @total = @total + DATEDIFF(MINUTE, @current_login_time, @current_logout_time)
				
				FETCH NEXT FROM CalculateAverage
					INTO
					@current_login_time,
					@current_logout_time

			END

		CLOSE CalculateAverage
		DEALLOCATE CalculateAverage

		set @average_time = @total / @count

		RETURN @average_time

	END

go

select 
	fld_user_activity_username,
	dbo.GetAverageLogInTime(fld_user_activity_username, '2020-02-23', '2020-02-18') as 'Average Minutes'
from 
	Tbl_User_Activity_Logs
Group by
	fld_user_activity_username












