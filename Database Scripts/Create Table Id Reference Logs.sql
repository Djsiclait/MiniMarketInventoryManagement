CREATE TABLE Tbl_Id_Reference_Logs
(
	fld_id_reference_id varchar(4),
	fld_id_reference_table varchar(100) Unique,
	fld_id_reference_iteration int Default 0,

	Primary Key (fld_id_reference_id)
)