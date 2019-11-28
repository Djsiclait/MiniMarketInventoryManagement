CREATE TABLE Tbl_Broken_Products 
(
	fld_broken_product_id varchar(10) NOT NULL, -- product identification number for any broken items 
	fld_broken_product_code varchar(100) Default '', --User assigned product identification number 
	fld_broken_product_name varchar(100) Default '', -- broken product name
	fld_broken_product_unit_cost decimal(7,2) Default 1.00, -- unit cost of broken product to take into account in financial reports; cost determined by FIFO/LIFO system
	fld_broken_product_unit_price decimal(7,2) Default 1.00, -- unit price of broken product to take into account in financial reports
	fld_broken_product_quantity_lost decimal(7,2) Default 1, -- quantity of product lost to update inventory stock levels 
	fld_broken_product_date datetime Default '', -- date product was broken
	fld_product_broken_by_employee varchar(50) Default NULL, -- username of employee responsible for breaking products, if applicable (Nullable)
	fld_product_broken_by_customer bit Default 0 -- if product were not broken by employees, this indicates if product was broken by a customer 
)