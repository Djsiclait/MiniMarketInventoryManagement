CREATE TABLE Tbl_Suppliers
(
	fld_supplier_id varchar(10),
	fld_supplier_name varchar(100) Unique,
	fld_supplier_phone_number varchar(100) Default '',
	fld_supplier_email varchar(200) Default '',
	
	Primary Key (fld_supplier_id)
)