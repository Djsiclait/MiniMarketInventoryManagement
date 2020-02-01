CREATE TABLE Tbl_Product_Brands
(
	fld_brand_id varchar(10) NOT NULL, -- Automatically generated identification code for product brands
	fld_brand_name varchar(100) Unique, -- name of product brand for categorization and grouping purposes 

	PRIMARY KEY (fld_brand_id)
)