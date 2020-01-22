CREATE TABLE Tbl_Error_Logs
(
	fld_error_code varchar(10) Default '', 
	fld_error_description varchar(300) Not Null,
	fld_error_username varchar(50) Not Null,
	fld_error_timestamp datetime Not Null
)