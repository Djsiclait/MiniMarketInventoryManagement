CREATE TABLE Tbl_Activity_Types 
(
	fld_type_id varchar(4) NOT NULL, -- automatically generated activity type code
	fld_type_description varchar(30) Default '', -- activity type description 

	PRIMARY KEY (fld_type_id)
)