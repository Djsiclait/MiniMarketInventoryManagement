 CREATE TABLE Tbl_Users
 (
	fld_user_username varchar(50),
	fld_user_first_name varchar(100) Not Null,
	fld_user_last_name varchar(100) Not Null,
	fld_user_role varchar(3) Not Null,

	Primary Key (fld_user_username)
 )