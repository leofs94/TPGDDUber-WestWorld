CREATE PROCEDURE WEST_WORLD.ItemView
	@NUMEROFACTURA bigint

AS

	SELECT i.idItem, descripcion, monto, cantidad, importe
	FROM WEST_WORLD.Factura_Item fi
	JOIN WEST_WORLD.Item i on (fi.idItem=i.idItem)
	WHERE numeroFactura = @NUMEROFACTURA

	OPTION (RECOMPILE)

RETURN 0