CREATE PROC SP_Register_New_Product_FLA
	@key varchar(100),
	@name varchar(300),
	@brand varchar(10),
	@supplier varchar(10),
	@category varchar(10),
	@type varchar(10),
	@unit varchar(30),
	@cost decimal(19,2),
	@price decimal(19,2),
	@quantity int,
	@minimum int,
	@maximum int,
	@username varchar(50),
	@format varchar(30),
	@message varchar(300) output
AS
	BEGIN

		IF @format = 'FIFO'
			BEGIN

				set @message = 'Register new product using FIFO'

			END

		IF @format = 'LIFO'
			BEGIN
				
				set @message = 'Register new product using LIFO'

			END

		IF @format = 'AVRG'
			BEGIN
			
				set @message = 'Register new product using Weightes Average'

			END

	END

















