CREATE PROCEDURE WEST_WORLD.ItemCreateOrUpdate
	@MODE nvarchar(10),
	@IDITEM bigint,
	@NUMEROFACTURA bigint,
	@DESCRIPCION nvarchar(255),
	@MONTO numeric(15,2),
	@CANTIDAD smallint,
	@IMPORTE numeric(15,2)

AS
	
	IF @mode='Add'
		BEGIN
			IF EXISTS (SELECT * FROM Factura_Item fi join Item i on (fi.idItem = i.idItem)
					   WHERE descripcion = @DESCRIPCION 
							and cantidad = @CANTIDAD 
							and numeroFactura = @NUMEROFACTURA)
				RETURN -1

			ELSE
				INSERT INTO WEST_WORLD.Factura_Item(numeroFactura, cantidad, monto, importe)
				VALUES(@NUMEROFACTURA, @CANTIDAD, @MONTO, @IMPORTE)

				INSERT INTO WEST_WORLD.Item(descripcion)
				VALUES(@DESCRIPCION)

				OPTION (RECOMPILE)
				RETURN 0
		END
	
	ELSE IF @mode ='Edit'
		BEGIN

			UPDATE WEST_WORLD.Factura_Item
			SET monto=@MONTO, 
				cantidad=@CANTIDAD,
				importe=@IMPORTE
			WHERE idItem = @IDITEM and numeroFactura = @NUMEROFACTURA

			UPDATE WEST_WORLD.Item
			SET descripcion=@DESCRIPCION
			WHERE idItem = @IDITEM 

		END

	RETURN 0