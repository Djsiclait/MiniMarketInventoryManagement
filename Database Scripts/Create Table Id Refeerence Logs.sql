CREATE TABLE Tbl_Id_Refrence_Logs
(
	fld_id_refrence_id varchar(4),
	fld_id_refrence_table varchar(100),
	fld_id_refrence_iteration int Default 0,

	Primary Key (fld_id_refrence_id)
)