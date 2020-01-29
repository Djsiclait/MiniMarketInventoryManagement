CREATE PROC SP_Username_Exists
	@username varchar(50), ---- username to verify availability
	@result bit output ---- answer to availability query
AS
	BEGIN
		
		IF exists(Select 1 from Tbl_Users where fld_user_username = @username)
			set @result = 1 ---- username is already in use and no longer available
		ELSE
			set @result = 0 ---- username is available for use

	END

go 

Declare @res tinyint

Exec SP_Username_Exists 'super', @res output

select @res
