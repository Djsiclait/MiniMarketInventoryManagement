CREATE PROC SP_Validate_User_Credentials_Data
	@username varchar(50),
	@password varchar(30),
	@message varchar(300) output
AS
	BEGIN
		
		Declare @query bit
		Exec SP_Username_Exists @username, @query output

		IF @query = 0
			set @message = 'Username does not exists'
		ELSE IF exists(select 1 from Tbl_Users where fld_user_username = @username and fld_user_status <> 0)
			set @message = 'User profile is currently inactive'
		ELSE IF exists(select 1 from Tbl_Users where fld_user_username = @username and fld_user_password <> @password)
			set @message = 'Password is incorrect'
		ELSE 
			set @message = 'Credentials validated'
			
	END

go

Declare @message varchar(300)

exec SP_Validate_User_Credentials_Data 'd.so', '', @message output	
select @message

exec SP_Validate_User_Credentials_Data 'p.siclait', '', @message output	
select @message

exec SP_Validate_User_Credentials_Data 'b.siclait', 'admin1234', @message output	
select @message








