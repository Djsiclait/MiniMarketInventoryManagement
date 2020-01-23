CREATE TABLE Tbl_Users
 (
	fld_user_username varchar(50),
	fld_user_first_name varchar(100) Not Null,
	fld_user_last_name varchar(100) Not Null,
	fld_user_role varchar(100) Not Null,
	fld_user_status tinyint Default 0, ---- 0 = Active, 1 = Inactive, 2 = Suspended

	Primary Key (fld_user_username)
 )