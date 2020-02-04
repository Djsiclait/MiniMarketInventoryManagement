CREATE PROC SP_Register_Product_Type
	@description varchar(50),
	@message varchar(300) output
AS
	BEGIN
	
		IF exists(select 1 from Tbl_Product_Type where fld_type_description = @description)
			set @message = 'This type is already registered'
		ELSE 
			BEGIN

				Declare @new_type_id varchar(10)
				exec SP_Generate_New_Id 'Product Types', @new_type_id output
		
				Insert Into Tbl_Product_Type
				(
					fld_type_id,
					fld_type_description
				)
				Values 
				(
					@new_type_id,
					UPPER(@description)
				)

				set @message = 'Supplier has been registered successfully!'

			END

	END






















