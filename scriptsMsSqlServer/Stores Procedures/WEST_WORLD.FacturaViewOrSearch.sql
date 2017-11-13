CREATE PROCEDURE WEST_WORLD.FacturaViewOrSearch
	@NUMEROFACTURA BIGINT

AS
	IF (@NUMEROFACTURA IS NOT NULL)
		SELECT numeroFactura, cliente, empresa, fechaAlta, fechaVencimiento, total
		FROM WEST_WORLD.Factura
		WHERE numeroFactura = @NUMEROFACTURA
	ELSE	
		SELECT * FROM WEST_WORLD.Factura
        OPTION (RECOMPILE)
RETURN 0