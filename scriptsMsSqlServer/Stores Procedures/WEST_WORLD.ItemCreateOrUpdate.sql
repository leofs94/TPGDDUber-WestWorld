CREATE PROCEDURE WEST_WORLD.ItemCreateOrUpdate
	@MODE nvarchar(10),
	@IDITEM bigint,
	@NUMEROFACTURA bigint,
	@MONTO numeric(15,2),
	@CANTIDAD smallint,
	@IMPORTE numeric(15,2)

AS
	
	IF @mode='Add'
		BEGIN
			IF EXISTS (SELECT * FROM Item 
					   WHERE numeroFactura = @NUMEROFACTURA AND monto = @MONTO 
							 AND cantidad = @CANTIDAD AND importe = @IMPORTE)
				RETURN -1

			ELSE
				INSERT INTO WEST_WORLD.Item(numeroFactura, cantidad, monto, importe)
				VALUES(@NUMEROFACTURA, @CANTIDAD, @MONTO, @IMPORTE)

				OPTION (RECOMPILE)
				RETURN 0
		END
	
	ELSE IF @mode ='Edit'
		BEGIN

			UPDATE WEST_WORLD.Item
			SET numeroFactura = @NUMEROFACTURA,
				monto=@MONTO, 
				cantidad=@CANTIDAD,
				importe=@IMPORTE
			WHERE idItem = @IDITEM
		END

	RETURN 0