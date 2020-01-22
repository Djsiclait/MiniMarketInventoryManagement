CREATE TABLE Tbl_Products
(
	fld_product_id varchar(10) NOT NULL, -- Automatic and random generation of product identification number for internal system usage; also needed for FIFO/LIFO accounting 
	fld_product_key varchar(100) Default '', -- User assigned product identification number for non accounting purposes
	fld_product_brand varchar(10) NOT NULL, -- Semi/automatic generated product brand company code
	fld_product_supplier varchar(10) NOT NULL, -- Semi/automatic generated product supplier code
	fld_product_unit varchar(30) Default '', -- Unit of measurment for product (i.e. unit, pack, 12oz, lb)  
	fld_product_category varchar(10) NOT NULL, -- Semi/automatic generated product cateory code 
	fld_product_type varchar(10) NOT NULL, -- Semi/automatic generated product type code
	fld_product_unit_cost Decimal(7,2) Default 1.00, -- purchase cost of an individual unit of the registered product
	fld_product_unit_price Decimal(7,2) Default 1.00, -- sales price of an individual unit of the registered product 
	fld_product_quantity int Default 1, -- current available total quantity of units in stock
	fld_product_minimum_quantity int Default 1, -- miminum unit quantity needed to determine understock level of registered product 
	fld_product_maximum_quantity int Default 2, -- maximum unit quantity needed to determine overstock level of registered product
	fld_product_registered_by varchar(50) NOT NULL, -- username of person responsible for registering the product for the first time
	fld_product_registration_date datetime Default GETDATE(), -- date product was first registered by a user
	fld_product_modified_by varchar(50) NOT NULL, -- username of last person to modify the product's information
	fld_product_modification_date datetime Default GETDATE(), -- date the product's information was last modified
	fld_product_discontinued bit Default 0, -- State of product within the general store

	PRIMARY KEY (fld_product_id)
)