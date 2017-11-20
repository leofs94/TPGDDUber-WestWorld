CREATE PROCEDURE WEST_WORLD.FacturaAsignarPago
	@NUMFACTURA bigint,
	@PAGO bigint

AS

	UPDATE WEST_WORLD.Factura
	SET pago = @PAGO
	WHERE numeroFactura = @NUMFACTURA