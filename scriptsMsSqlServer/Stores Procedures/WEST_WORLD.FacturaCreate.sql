CREATE PROCEDURE WEST_WORLD.FacturaCreate
	@NUMEROFACTURA numeric(15,0),
	@CLIENTE bigint,
	@EMPRESA bigint,
	@FECHA_ALTA datetime,
	@FECHA_VENC datetime,
	@TOTAL numeric(15,5)

AS

	INSERT INTO WEST_WORLD.Factura(numeroFactura, cliente, empresa, fechaAlta, fechaVencimiento, total)
	VALUES(@NUMEROFACTURA, @CLIENTE, @EMPRESA, @FECHA_ALTA, @FECHA_VENC, @TOTAL)

	OPTION (RECOMPILE)
RETURN 0
