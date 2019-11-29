CREATE TABLE Tbl_Movement_Types
(
	fld_type_id varchar(4) NOT NULL, -- Automatically generated identification code for movement type
	fld_type_description varchar(100) Default '', -- description of movement type

	PRIMARY KEY (fld_type_id)
)