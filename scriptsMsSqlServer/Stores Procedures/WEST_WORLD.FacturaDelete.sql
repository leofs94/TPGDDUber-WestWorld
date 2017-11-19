CREATE PROCEDURE WEST_WORLD.FacturaDelete
@NUMEROFACTURA bigint

AS
	IF EXISTS (SELECT * FROM WEST_WORLD.Factura
				WHERE numeroFactura=@NUMEROFACTURA AND pago IS NULL AND rendicion IS NULL)
		BEGIN
		
			DECLARE @idItem bigint

			SET @idItem = (SELECT idItem FROM WEST_WORLD.Item
							WHERE numeroFactura=@NUMEROFACTURA)

			DELETE FROM WEST_WORLD.Item
			WHERE numeroFactura = @NUMEROFACTURA and idItem = @idItem

			DELETE FROM WEST_WORLD.Factura
			WHERE numeroFactura=@NUMEROFACTURA
			RETURN 0
		END
	ELSE 
		RETURN -1