CREATE PROCEDURE WEST_WORLD.ItemView
	@NUMEROFACTURA numeric(15,0)
AS

	SELECT descripcion, monto, cantidad
	FROM WEST_WORLD.Factura_Item fi
	JOIN WEST_WORLD.Item i on (fi.idItem=i.idItem)
	WHERE numeroFactura=@NUMEROFACTURA
    OPTION (RECOMPILE)

RETURN 0