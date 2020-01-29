CREATE PROC SP_Create_New_User
	@username varchar(50), ---- username of the new user profile
	@password varchar(30), ---- password for the new user account
	@first_name varchar(100), ---- first name of the user
	@last_name varchar(100), ---- last name of the user
	@role varchar(100), ---- user role within the system whether Admin or basic User
	@creator varchar(50), ---- user name of the person who created this new profile 
	@message varchar(300) output ---- message output to confirm or reject user profile creation
AS
	BEGIN
		
		Declare @query bit ---- variable to confirm username validation 
		Exec SP_Username_Exists @username, @query output ---- using created stored procedure to confrim availability of a given username amongst the registered users

		IF @query = 1 ---- username is (or has) been used before and is no longer available
			set @message = 'This username is already registered'
		ELSE
			BEGIN
				
				Insert Into Tbl_Users ---- Creating new user profile
				(
					fld_user_username,
					fld_user_password,
					fld_user_first_name,
					fld_user_last_name,
					fld_user_role,
					fld_user_creator
				)
				Values
				(
					@username,
					@password,
					@first_name,
					@last_name,
					@role,
					@creator
				)

				set @message = 'User created' ---- creation of profile has been successful

			END

	END

go

Declare @message varchar(300)

exec SP_Create_New_User 'super.admin', 'admin', '', '', 'Super', 'super.admin', @message output

select @message

select * from Tbl_Users







