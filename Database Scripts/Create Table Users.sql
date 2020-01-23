CREATE TABLE Tbl_Users
 (
	fld_user_username varchar(50),
	fld_user_first_name varchar(100) Not Null,
	fld_user_last_name varchar(100) Not Null,
	fld_user_role varchar(100) Not Null,
	fld_user_creator varchar(50) Default 'super.admin',
	fld_user_registration_date datetime Default GETDATE(),
	fld_user_status tinyint Default 0, ---- 0 = Active, 1 = Inactive, 2 = Suspended
	fld_user_last_login_timestamp datetime, 

	Primary Key (fld_user_username)
 )