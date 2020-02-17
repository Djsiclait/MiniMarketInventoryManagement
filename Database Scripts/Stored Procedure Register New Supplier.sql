Alter PROC SP_Register_New_Supplier
	@name varchar(100),
	@phone_number varchar(100),
	@email varchar(200),
	@message varchar(300) output
AS
	BEGIN
		
		IF exists(select 1 from Tbl_Suppliers where fld_supplier_name = UPPER(@name))
			set @message = 'This supplier is already registered'
		ELSE 
			BEGIN
				
				Declare @new_supplier_id varchar(10)
				exec SP_Generate_New_Id 'Suppliers', @new_supplier_id output

				Insert Into Tbl_Suppliers
				(
					fld_supplier_id,
					fld_supplier_name,
					fld_supplier_phone_number,
					fld_supplier_email
				)
				Values
				(
					@new_supplier_id,
					UPPER(@name),
					@phone_number,
					@email
				)

				set @message = 'Supplier has been registered successfully!'

			END

	END

go

begin tran

Declare @message varchar(300)

exec SP_Register_New_Supplier '', '', '', @message output
select @message
exec SP_Register_New_Supplier 'Rica', '', 'rica@gmail.com', @message output
select @message
exec SP_Register_New_Supplier 'Maggi', '', '', @message output
select @message
exec SP_Register_New_Supplier 'Presidente', '', 'presidente@gmail.com', @message output
select @message
exec SP_Register_New_Supplier 'Eduardo Cosme Agente de Presidente', '8096606263', 'e.c.presidente@gmail.com', @message output
select @message
exec SP_Register_New_Supplier 'Suplidor Nacional', '8292184635', '', @message output
select @message

select * from Tbl_Suppliers

rollback

















