CREATE TABLE Tbl_Product_Logs
(
	fld_product_id varchar(10) NOT NULL, -- utomatic and random generation of product identification number
	fld_product_movement_type varchar(4), -- identification code of the movement type for auditory purposes
	fld_product_movement_date datetime Default '', -- date and time product stock was modified by a movement
	fld_product_movement_quantity int Default 1.00, -- quantity of products moved
	fld_product_movenment_total_cost decimal(7,2) Default 0.00 -- total worth of the product movement
)