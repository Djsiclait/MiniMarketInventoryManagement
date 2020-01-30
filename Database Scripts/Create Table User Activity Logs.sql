CREATE TABLE Tbl_User_Activity_Logs
(
	fld_user_activity_username varchar(50) Not Null,
	fld_user_activity_description varchar(300) Not Null,
	fld_user_activity_timestamp datetime Default GETDATE(),
	fld_user_activity_type varchar(100) Not Null
)