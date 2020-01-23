Create PROC SP_Register_New_User
	@username varchar(50),
	@firstName varchar(100),
	@lastName varchar(100),
	@creator varchar(50),
	@role tinyint,
	@message varchar(300) output
AS
	BEGIN
		
		IF exists(select 1 from tbl_users where fld_user_username = @username)
			set @message = 'Username already exist'
		ELSE IF Not exists(select 1 from tbl_users where fld_user_username = @username)
			BEGIN

				Insert Into tbl_users
				(
					fld_user_username,
					fld_user_first_name,
					fld_user_last_name,
					fld_user_creator,
					fld_user_role
				)
				values
				(
					@username,
					@firstName,
					@lastName,
					@creator,
					(
						CASE
							WHEN @role = 0 THEN 'Super'
							WHEN @role = 1 THEN 'Admin'
							ELSE 'User'
						END
					)
				)

				set @message = 'User, ' + @username + ', was created successfully!'

			END
		ELSE
			set @message = 'FATAL ERROR'

	END

go

Begin tran 

declare @message varchar(300)

exec SP_Register_New_User 'super.admin', '', '', 'super.admin', 0, @message output
select @message

exec SP_Register_New_User 'djsiclait', 'Djidjelly', 'Siclait', 'super.admin', 1, @message output
select @message
exec SP_Register_New_User 'bsiclait', 'Biderka', 'Siclait', 'djsiclait', 2, @message output
select @message

select * from tbl_users

rollback








