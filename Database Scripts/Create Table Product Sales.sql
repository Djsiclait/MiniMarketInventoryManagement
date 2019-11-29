CREATE TABLE Tbl_Product_Sales
(
	fld_product_id varchar(10) NOT NULL, -- internal identification code of product sold
	fld_sale_id varchar(100) NOT NULL, -- internal identfication code of sales transaction 
	fld_product_quantity int Default 1, -- quantity of purchased product 
	fld_product_unit_price decimal(7,2), -- unit price of purchased product

	PRIMARY KEY (fld_product_id, fld_sale_id)
)