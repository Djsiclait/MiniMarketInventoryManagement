CREATE TABLE Tbl_Sales
(
	fld_sale_id varchar(10),
	fld_sale_quantity_items int Default 1,
	fld_sale_total decimal(19,0) Default 0,
	fld_sale_delivery bit Default 0, ---- 0 = In store sale; 1 = Delivery 
	fld_sale_date datetime Default GETDATE(),
	fld_sold_by varchar(50) Not Null, ---- User that completed the sale
	fld_sale_status tinyint Default 0,
	fld_sale_parent varchar(10) Default '',
	fld_sale_child varchar(10) Default '',

	Primary Key (fld_sale_id)
)