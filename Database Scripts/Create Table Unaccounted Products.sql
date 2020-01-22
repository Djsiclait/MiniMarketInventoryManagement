CREATE TABLE Tbl_Unccaountes_Products
(
	fld_unaccounted_product_id varchar(10) Not Null, -- Automatic and random generation of product identification number for internal system usage; also needed for FIFO/LIFO accounting 
	fld_unaccounted_product_name varchar(100) Not Null,
	fld_unaccounted_product_code varchar(100) Not Null, -- User assigned product identification number for non accounting purposes
	fld_unaccounted_product_unit_cost decimal(19,2) Not Null,
	fld_unaccounted_product_unit_price decimal(19,2) Not Null, 
	fld_unaccounted_product_quantity int Default 1,
	fld_unaccounted_product_date datetime Not Null,
	fld_unaccounted_product_broken_type varchar(4) Not Null
)